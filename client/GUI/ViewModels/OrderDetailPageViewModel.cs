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
        private string _OrderIDFromOrderPage;
        private List<Book> _booksFromOrder = new List<Book>();
        private ObservableCollection<BookWithNotion> _booksWithNotion;
        private Dictionary<string, IBus> _bus = BusInstance._bus;
        private string _quantityErrorMessage;
        public bool isSave = true;
        public bool isDelete = false;
        public string failMessage = "";

        public ICommand UpdateOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }

        public OrderDetailPageViewModel(List<Book> books, string orderIDFromOrderPage)
        {
            var configuration = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            _booksFromOrder = books;
            _OrderIDFromOrderPage = orderIDFromOrderPage;
            _booksWithNotion = new ObservableCollection<BookWithNotion>();

            foreach (var book in _booksFromOrder)
            {
                _booksWithNotion.Add(ConvertToBookWithNotion(book));
                Debug.WriteLine("[OrderDetailPageViewModel] bookID: " + book.ID);
            }

            foreach (var bookWithNotion in _booksWithNotion)
            {
                bookWithNotion.PropertyChanged += BookWithNotion_PropertyChanged;
            }

            UpdateOrderCommand = new RelayCommand(SaveOrder, CanSaveOrder);
            DeleteOrderCommand = new RelayCommand(DeleteOrder);
        }

        private void BookWithNotion_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BookWithNotion.OrderQuantity) || e.PropertyName == nameof(BookWithNotion.IsSelected))
            {
                OnPropertyChanged(nameof(TotalAmount));
            }
        }

        private BookWithNotion ConvertToBookWithNotion(Book book)
        {
            return new BookWithNotion(book, this);
        }

        public ObservableCollection<BookWithNotion> BooksWithNotion
        {
            get => _booksWithNotion;
            set => SetProperty(ref _booksWithNotion, value);
        }

        public List<Book> BooksFromOrder
        {
            get => _booksFromOrder;
            set => SetProperty(ref _booksFromOrder, value);
        }

        public decimal TotalAmount => BooksWithNotion.Where(b => b.IsSelected).Sum(b => b.Subtotal);

        public string QuantityErrorMessage
        {
            get => _quantityErrorMessage;
            set => SetProperty(ref _quantityErrorMessage, value);
        }

        internal void UpdateQuantityErrorMessage()
        {
            var errorMessage = BooksWithNotion.Any(b => b.OrderQuantity <= 0
            || b.OrderQuantity > b.QuantityAvailable)
                ? "Số lượng nhập không hợp lệ."
                : null;
            QuantityErrorMessage = errorMessage;
        }

        private void SaveOrder()
        {
            isSave = true;
            Debug.WriteLine("SaveOrder_func 1" + isSave);

            // Lấy danh sách những quyển sách đã được chọn
            var selectedBooks = BooksWithNotion.Where(b => b.IsSelected).ToList();

            // Danh sách chọn rỗng -> Không cho update
            if (selectedBooks.Count == 0)
            {
                isSave = false;
                Debug.WriteLine("SaveOrder_func count" + isSave);
                failMessage = "Can't update order with no book selected.";
            }
            else
            {
                // create new order
                var order = new Order();
                var configuration = new Dictionary<string, string> { { "id", _OrderIDFromOrderPage } };
                order = _bus["Order"].Get(configuration);
                order.total = (int)TotalAmount;

                List<dynamic> newOrder = new List<dynamic>();
                List<Book> booksForUpdate = new List<Book>();
                int orderQuantityBeforeUpdate = 0;

                foreach (var booksWithNotion in selectedBooks)
                {
                    var book = new Book();
                    book = booksWithNotion.Book;
                    orderQuantityBeforeUpdate = OderQuantityBeforeUpdate(book.ID);

                    int tempOrderQuantity = booksWithNotion.QuantityAvailable - booksWithNotion.OrderQuantity;
                    // Tồn tại một quyển sách có số lượng mua là 0 hoặc số lượng tồn không đủ
                    // thì không cho tạo mới đơn hàng
                    if (tempOrderQuantity > 0 && booksWithNotion.OrderQuantity > 0)
                    {
                        if (tempOrderQuantity < orderQuantityBeforeUpdate)
                        {
                            // giảm số lượng sách xuống
                            // -> tăng số lượng sách trong kho và giảm lượng sách đã bán
                            book.quantity = book.quantity + (orderQuantityBeforeUpdate - tempOrderQuantity);
                            book.total_sold = book.total_sold - (orderQuantityBeforeUpdate - tempOrderQuantity);
                            book.order_quantity = booksWithNotion.OrderQuantity;
                            newOrder.Add(new { id = book.ID, quantity = booksWithNotion.OrderQuantity });
                            booksForUpdate.Add(book);
                            _bus["Book"].Patch(book, null);
                        } else if (tempOrderQuantity > orderQuantityBeforeUpdate)
                        {
                            // tăng số lượng sách lên
                            // -> giảm số lượng sách trong kho và tăng lượng sách đã bán
                            book.quantity = book.quantity - (tempOrderQuantity - orderQuantityBeforeUpdate);
                            book.total_sold = book.total_sold + (tempOrderQuantity - orderQuantityBeforeUpdate);
                            book.order_quantity = booksWithNotion.OrderQuantity;
                            newOrder.Add(new { id = book.ID, quantity = booksWithNotion.OrderQuantity });
                            booksForUpdate.Add(book);
                            _bus["Book"].Patch(book, null);
                        } else
                        {
                            // không thay đổi số lượng sách
                            // -> không thay đổi số lượng sách trong kho và lượng sách đã bán
                            newOrder.Add(new { id = book.ID, quantity = booksWithNotion.OrderQuantity });
                        }
                    }
                    else
                    {
                        isSave = false;
                        Debug.WriteLine("SaveOrder_func quantity " + isSave);
                        failMessage = "Can't update order with invalid quantity.";
                        return;
                    }

                }
                Debug.WriteLine("SaveOrder_func last " + isSave);
                if (isSave)
                {
                    order.books = newOrder;
                    _bus["Order"].Patch(order, configuration);
                }
            }
        }

        private void DeleteOrder()
        {
            var configuration = new Dictionary<string, string> { { "id", _OrderIDFromOrderPage } };
            isDelete = _bus["Order"].Delete(configuration);
            Debug.WriteLine("[OrderDetailPageViewModel] isDelete: " + isDelete);
            Debug.WriteLine("[OrderDetailPageViewModel] ID: " + _OrderIDFromOrderPage);
        }

        private bool CanSaveOrder()
        {
            // Kiểm tra xem có thể lưu đơn hàng hay không (kiểm tra các điều kiện hợp lệ)

            // Return true nếu có thể lưu, ngược lại false
            return true; // hoặc thêm các điều kiện kiểm tra khác
        }

        private int OderQuantityBeforeUpdate(int bookID)
        {
            int orderQuantity = 0;
            foreach (var book in _booksFromOrder)
            {
                if (book.ID == bookID)
                {
                    orderQuantity = book.order_quantity;
                }
            }
            return orderQuantity;
        }
    }

    public class BookWithNotion : ObservableObject
    {
        private bool _isSelected = true;
        private Book _book;
        private int _order_quantity = 1;
        private SolidColorBrush _quantityInputColor = new SolidColorBrush(Colors.Black);
        private OrderDetailPageViewModel _parentViewModel;

        public BookWithNotion(Book book, OrderDetailPageViewModel parentViewModel)
        {
            _book = book;
            _order_quantity = book.order_quantity;
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

        public int OrderQuantity
        {
            get => _order_quantity;
            set
            {
                if (SetProperty(ref _order_quantity, value))
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

        public decimal Subtotal => IsSelected ? _book.price * OrderQuantity : 0;

        public decimal TotalAmount => IsSelected ? _book.price * OrderQuantity : 0;

        private void UpdateQuantityValidity()
        {
            if (OrderQuantity <= 0 || OrderQuantity > QuantityAvailable)
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
