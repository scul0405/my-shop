using CommunityToolkit.Mvvm.ComponentModel;
using Entity;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using ThreeLayerContract;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using System;

namespace GUI.ViewModels
{
    public class CreateOrderViewModel : ObservableObject
    {
        private ObservableCollection<BookWithSelection> _booksWithSelection;
        private Dictionary<string, IBus> _bus = BusInstance._bus;
        private string _quantityErrorMessage;

        public ICommand SaveOrderCommand { get; }

        public CreateOrderViewModel()
        {
            var configuration = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            List<Book> availableBooks = new List<Book>(_bus["Book"].Get(configuration));

            _booksWithSelection = new ObservableCollection<BookWithSelection>();

            foreach (var book in availableBooks)
            {
                _booksWithSelection.Add(ConvertToBookWithSelection(book));
            }

            foreach (var bookWithSelection in _booksWithSelection)
            {
                bookWithSelection.PropertyChanged += BookWithSelection_PropertyChanged;
            }

            SaveOrderCommand = new RelayCommand(SaveOrder, CanSaveOrder);
        }

        private void BookWithSelection_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BookWithSelection.Quantity) || e.PropertyName == nameof(BookWithSelection.IsSelected))
            {
                OnPropertyChanged(nameof(TotalAmount));
            }
        }

        private BookWithSelection ConvertToBookWithSelection(Book book)
        {
            return new BookWithSelection(book, this);
        }

        public ObservableCollection<BookWithSelection> BooksWithSelection
        {
            get => _booksWithSelection;
            set => SetProperty(ref _booksWithSelection, value);
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
            // Lấy danh sách những quyển sách đã được chọn
            var selectedBooks = BooksWithSelection.Where(b => b.IsSelected).ToList();

            // Chuyển danh sách này thành book
            var books = selectedBooks.Select(b => b.Book).ToList();

            // in id sách đã chọn
            foreach (var book in books)
            {
                System.Diagnostics.Debug.WriteLine(book.ID);
            }

            // create new order
            var order = new Order();
            order.total = (int)TotalAmount;
            order.books = books;
            order.Id = 2;

            //if (_bus["Order"].Post(order, null))
            //{
            //    // Update quantity and total sold of selected books
            //    foreach (var booksWithSelection in selectedBooks)
            //    {
            //        var book = new Book();
            //        book = booksWithSelection.Book;

            //        book.quantity = booksWithSelection.QuantityAvailable - booksWithSelection.Quantity;
            //        book.total_sold = book.total_sold + booksWithSelection.Quantity;
            //        _bus["Book"].Patch(book, null);
            //    }
            //}

        }

        private bool CanSaveOrder()
        {
            // Kiểm tra xem có thể lưu đơn hàng hay không (kiểm tra các điều kiện hợp lệ)

            // Return true nếu có thể lưu, ngược lại false
            return true; // hoặc thêm các điều kiện kiểm tra khác
        }
    }

    public class BookWithSelection : ObservableObject
    {
        private bool _isSelected = false;
        private Book _book;
        private int _quantity = 1;
        private SolidColorBrush _quantityInputColor = new SolidColorBrush(Colors.Black);
        private CreateOrderViewModel _parentViewModel;

        public BookWithSelection(Book book, CreateOrderViewModel parentViewModel)
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
        public int QuantityAvailable => _book.quantity;

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
