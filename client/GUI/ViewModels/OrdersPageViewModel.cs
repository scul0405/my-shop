using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Entity;
using GUI.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

            Refresh();
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
            var configuration = new Dictionary<string, string> {
               { "page", pageIndex.ToString() },                         
               { "size", pageSize.ToString() },                                          
            };

            List<Order> orders = new List<Order>(_bus["Order"].Get(configuration));

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
            _pageNumber = 0;
            FirstCommand.Execute(null);
        }

        private int CalculatePageCount(int pageSize)
        {
            var configuration = new Dictionary<string, string> {
            };

            List<Order> orders = new List<Order>(_bus["Order"].Get(configuration));
            return (int)Math.Ceiling((double)orders.Count / pageSize);
        }
    }
}
