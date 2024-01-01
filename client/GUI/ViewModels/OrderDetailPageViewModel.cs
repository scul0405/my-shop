using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Entity;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ThreeLayerContract;

namespace GUI.ViewModels
{
    public class OrderDetailPageViewModel : ObservableObject
    {
        private Order orderFromOrderPage;
        private ObservableCollection<BookWithNotion> _booksWithNotion;
        private Dictionary<string, IBus> _bus = BusInstance._bus;
        private string _quantityErrorMessage;
        public bool isSave = true;
        public string failMessage = "";

        public ICommand SaveOrderCommand { get; }

        public OrderDetailPageViewModel()
        {
            var configuration = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            List<Book> availableBooks = new List<Book>(_bus["Book"].Get(configuration));

            _booksWithNotion = new ObservableCollection<BookWithNotion>();

            foreach (var book in availableBooks)
            {
                _booksWithNotion.Add(ConvertToBookWithNotion(book));
            }

            foreach (var bookWithSelection in _booksWithNotion)
            {
                bookWithSelection.PropertyChanged += BookWithSelection_PropertyChanged;
            }

            SaveOrderCommand = new RelayCommand(SaveOrder, CanSaveOrder);
        }

        private void BookWithSelection_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BookWithNotion.Quantity) || e.PropertyName == nameof(BookWithNotion.IsSelected))
            {
                OnPropertyChanged(nameof(TotalAmount));
            }
        }

        private BookWithNotion ConvertToBookWithNotion(Book book)
        {
            return new BookWithNotion(book, this);
        }

        public ObservableCollection<BookWithNotion> BooksWithSelection
        {
            get => _booksWithNotion;
            set => SetProperty(ref _booksWithNotion, value);
        }

        public decimal TotalAmount => BooksWithSelection.Where(b => b.IsSelected).Sum(b => b.Subtotal);

        public string QuantityErrorMessage
        {
            get => _quantityErrorMessage;
            set => SetProperty(ref _quantityErrorMessage, value);
        }

        internal void UpdateQuantityErrorMessage()
        {
            var errorMessage = BooksWithSelection.Any(b => b.Quantity <= 0
            || b.Quantity > b.QuantityAvailable)
                ? "Số lượng nhập không hợp lệ."
                : null;
            QuantityErrorMessage = errorMessage;
        }

        private void SaveOrder()
        {
            isSave = true;
            Debug.WriteLine("SaveOrder_func 1" + isSave);

            // Lấy danh sách những quyển sách đã được chọn
            var selectedBooks = BooksWithSelection.Where(b => b.IsSelected).ToList();

            // Danh sách chọn rỗng -> Không cho tạo đơn
            if (selectedBooks.Count == 0)
            {
                isSave = false;
                Debug.WriteLine("SaveOrder_func count" + isSave);
                failMessage = "Can't create order with no book selected.";
            }
            else
            {
                // create new order
                var order = new Order();
                order.total = (int)TotalAmount;
                var configuration = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
                List<dynamic> newOrder = new List<dynamic>();

                foreach (var booksWithSelection in selectedBooks)
                {
                    var book = new Book();
                    book = booksWithSelection.Book;

                    int tempQuantity = booksWithSelection.QuantityAvailable - booksWithSelection.Quantity;
                    // Tồn tại một quyển sách có số lượng mua là 0 hoặc số lượng tồn không đủ
                    // thì không cho tạo mới đơn hàng
                    if (tempQuantity > 0 && booksWithSelection.Quantity > 0)
                    {
                        book.quantity = tempQuantity;
                        book.total_sold = book.total_sold + booksWithSelection.Quantity;
                        newOrder.Add(new { id = book.ID, quantity = booksWithSelection.Quantity });
                        _bus["Book"].Patch(book, null);
                    }
                    else
                    {
                        isSave = false;
                        Debug.WriteLine("SaveOrder_func quantity " + isSave);
                        failMessage = "Can't create order with invalid quantity.";
                        return;
                    }

                }
                Debug.WriteLine("SaveOrder_func last " + isSave);
                if (isSave)
                {
                    order.books = newOrder;
                    _bus["Order"].Post(order, null);
                }
            }
        }

        private bool CanSaveOrder()
        {
            // Kiểm tra xem có thể lưu đơn hàng hay không (kiểm tra các điều kiện hợp lệ)

            // Return true nếu có thể lưu, ngược lại false
            return true; // hoặc thêm các điều kiện kiểm tra khác
        }
    }

    public class BookWithNotion : ObservableObject
    {
        private bool _isSelected = false;
        private Book _book;
        private int _quantity = 1;
        private SolidColorBrush _quantityInputColor = new SolidColorBrush(Colors.Black);
        private OrderDetailPageViewModel _parentViewModel;

        public BookWithNotion(Book book, OrderDetailPageViewModel parentViewModel)
        {
            _book = book;
            _parentViewModel = parentViewModel;
        }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (SetProperty(ref _isSelected, value))
                {
                    OnPropertyChanged(nameof(Subtotal));
                    OnPropertyChanged(nameof(TotalAmount));
                }
            }
        }

        public Book Book => _book;
        public int Id => _book.ID;
        public string Name => _book.name;
        public string Author => _book.author;
        public decimal Price => _book.price;
        public int QuantityAvailable
        {
            get => _book.quantity;
            set
            {
                if (value >= 0)
                {
                    _book.quantity = value;
                }
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (SetProperty(ref _quantity, value))
                {
                    OnPropertyChanged(nameof(Subtotal));
                    OnPropertyChanged(nameof(TotalAmount));
                    UpdateQuantityValidity();
                }
            }
        }

        public SolidColorBrush QuantityInputColor
        {
            get => _quantityInputColor;
            set => SetProperty(ref _quantityInputColor, value);
        }

        public decimal Subtotal => IsSelected ? _book.price * Quantity : 0;

        public decimal TotalAmount => IsSelected ? _book.price * Quantity : 0;

        private void UpdateQuantityValidity()
        {
            if (Quantity <= 0 || Quantity > QuantityAvailable)
            {
                QuantityInputColor = new SolidColorBrush(Colors.Red);
                _parentViewModel?.UpdateQuantityErrorMessage();
            }
            else
            {
                QuantityInputColor = new SolidColorBrush(Colors.Black);
                _parentViewModel?.UpdateQuantityErrorMessage();
            }
        }
    }
}
