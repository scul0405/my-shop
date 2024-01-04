using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Entity;
using GUI.Services;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using ThreeLayerContract;
using Windows.Foundation.Numerics;

namespace GUI.ViewModels
{
    public class OrdersPageViewModel : ObservableObject
    {
        private int _pageSize = 10;
        private int _pageNumber;
        private int _pageCount;
        private List<Order> _orders;
        Dictionary<string, IBus> _bus = BusInstance._bus;
        private DateTime _fromDate = DateTime.MinValue;
        private DateTime _toDate = DateTime.MaxValue;

        public OrdersPageViewModel()
        {
            FirstCommand = new RelayCommand(
                () => GetOrders(1, _pageSize),
                () => _pageNumber != 1
            );
            PreviousCommand = new RelayCommand(
                () => GetOrders(_pageNumber - 1, _pageSize),
                () => _pageNumber > 1
            );
            NextCommand = new RelayCommand(
                () => GetOrders(_pageNumber + 1, _pageSize),
                () => _pageNumber < _pageCount
            );
            LastCommand = new RelayCommand(
                () => GetOrders(_pageCount, _pageSize),
                () => _pageNumber != _pageCount
            );

            FromDateChangedCommand = new RelayCommand<DateTime>(OnFromDateChanged);
            ToDateChangedCommand = new RelayCommand<DateTime>(OnToDateChanged);

            Refresh();
        }

        // ICommand để xử lý sự kiện thay đổi ngày của FromDate và ToDate
        public ICommand FromDateChangedCommand { get; }
        public ICommand ToDateChangedCommand { get; }

        public void ClearFilter()
        {
            Debug.WriteLine("[ClearFilter]: onlick");
            // Xóa bộ lọc và cập nhật dữ liệu
            FromDate = DateTime.MinValue;
            ToDate = DateTime.MaxValue;

            // Gọi Refresh để cập nhật dữ liệu mới
            Refresh();
        }

        public DateTime ToDate
        {
            get { return _toDate; }
            set
            {
                if (_toDate != value)
                {
                    
                    SetProperty(ref _toDate, value);
                    Debug.WriteLine("[ToDate]: Change, val: " + _toDate.ToString("yyyy-MM-dd"));
                    Refresh();
                }
            }
        }

        public DateTime FromDate
        {
            get { return _fromDate; }
            set
            {
                if (_fromDate != value)
                {
                    
                    SetProperty(ref _fromDate, value);
                    Debug.WriteLine("[FromDate]: Change, val: " + _fromDate.ToString("yyyy-MM-dd"));
                    Refresh();
                }
            }
        }


        private void OnFromDateChanged(DateTime fromDate)
        {
            FromDate = fromDate;
        }

        private void OnToDateChanged(DateTime toDate)
        {
            ToDate = toDate;
        }

        public List<int> PageSizes => new() { 5, 10, 20, 50, 100 };

        public int PageSize
        {
            get => _pageSize;
            set
            {
                SetProperty(ref _pageSize, value);
                Refresh();
            }
        }

        public int PageNumber
        {
            get => _pageNumber;
            private set => SetProperty(ref _pageNumber, value);
        }

        public int PageCount
        {
            get => _pageCount;
            private set => SetProperty(ref _pageCount, value);
        }

        public List<Order> Orders
        {
            get => _orders;
            private set => SetProperty(ref _orders, value);
        }

        public IRelayCommand FirstCommand { get; }

        public IRelayCommand PreviousCommand { get; }

        public IRelayCommand NextCommand { get; }

        public IRelayCommand LastCommand { get; }

        public void InitializeAsync()
        {
            GetOrders(1, _pageSize);
        }

        private void GetOrders(int pageIndex, int pageSize)
        {
            // Lấy danh sách đơn hàng từ API
            List<Order> orders;
            var configuration = new Dictionary<string, string> {
               { "page", pageIndex.ToString() },
               { "size", pageSize.ToString() },
               { "from", FromDate.ToString("yyyy-MM-dd")},
               { "to", ToDate.ToString("yyyy-MM-dd")}
            };

            try
            {
                orders = new List<Order>(_bus["Order"].Get(configuration));
                foreach (var order in orders)
                {
                    Tuple<bool, List<dynamic>> result = isUpdateStatusOrder(order);
                    if (result.Item1)
                    {
                        order.status = false;
                        order.books = result.Item2;
                        _bus["Order"].Patch(order, null);
                        Debug.WriteLine("Update status order to false of id: " + order.Id);
                    }
                }
                
            }
            catch
            {
                orders = new List<Order>();
            }

            // Tính toán các thuộc tính phân trang
            PageNumber = pageIndex;
            PageCount = CalculatePageCount(pageSize);

            // Gán danh sách đơn hàng trực tiếp
            Orders = orders;

            // Cập nhật trạng thái của các nút điều hướng
            FirstCommand.NotifyCanExecuteChanged();
            PreviousCommand.NotifyCanExecuteChanged();
            NextCommand.NotifyCanExecuteChanged();
            LastCommand.NotifyCanExecuteChanged();
        }

        private void Refresh()
        {
            Debug.WriteLine("[Refresh]: onlick");
            _pageNumber = 0;
            FirstCommand.Execute(null);
        }

        private int CalculatePageCount(int pageSize)
        {
            List<Order> orders;
            double count = 0;
            var configuration = new Dictionary<string, string> {
                    { "size", "100000" }
            };
            try
            {
                orders = new List<Order>(_bus["Order"].Get(configuration));
                count = (double)orders.Count;
            }
            catch
            {
                // eat
            }
            return (int)Math.Ceiling(count / pageSize);
        }

        private Tuple<bool, List<dynamic>> isUpdateStatusOrder(Order order)
        {
            // Lấy hết sách của đơn hàng
            // Sau đó kiểm tra, nếu tồn tại một quyển sách có status = false 
            // thì cập nhật trạng thái đơn bằng false
            Tuple<bool, List<dynamic>> result;
            bool isUpdate = false;
            int ID = order.Id;
            var configuration = new Dictionary<string, string> { { "id", ID.ToString() } };
            Order myOrder = new Order();
            List<dynamic> orderBooks = new List<dynamic>();
            try
            {
                myOrder = _bus["Order"].Get(configuration);
            }
            catch
            {
                //eat
            }

            if (myOrder.books != null)
            {
                orderBooks = myOrder.books;
                foreach (var item in myOrder.books)
                {
                    Book book = new Book();
                    book = ConvertToSpecificBook(item);
                    if (book.status == false)
                    {
                        // Lập tức trả về giá trị boolean
                        isUpdate = true;
                        break;
                    }
                    Debug.WriteLine("Book id " + book.ID);
                }
            } else
            {
               Debug.WriteLine("Order books of " + ID + " is null");
            }
            result = Tuple.Create(isUpdate, orderBooks);
            return result;
        }

        private Book ConvertToSpecificBook(dynamic book)
        {
            Book specificBook = new Book
            {
                ID = book.ID,
                category_id = book.category_id,
                name = book.name,
                author = book.author,
                desc = book.desc,
                price = book.price,
                total_sold = book.total_sold,
                order_quantity = book.order_quantity,
                quantity = book.quantity,
                status = book.status != null ? book.status : false
            };

            return specificBook;
        }
    }
}
