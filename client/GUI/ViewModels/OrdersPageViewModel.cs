using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Entity;
using GUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Core;

namespace GUI.ViewModels
{
    public class OrdersPageViewModel : ObservableObject
    {
        private int _pageSize = 10;
        private int _pageNumber;
        private int _pageCount;
        private List<Order> _orders;

        public OrdersPageViewModel()
        {
            FirstAsyncCommand = new AsyncRelayCommand(
                async () => await GetOrders(1, _pageSize),
                () => _pageNumber != 1
              );
            PreviousAsyncCommand = new AsyncRelayCommand(
                async () => await GetOrders(_pageNumber - 1, _pageSize),
                () => _pageNumber > 1
              );
            NextAsyncCommand = new AsyncRelayCommand(
                async () => await GetOrders(_pageNumber + 1, _pageSize),
                () => _pageNumber < _pageCount
              );
            LastAsyncCommand = new AsyncRelayCommand(
                async () => await GetOrders(_pageCount, _pageSize),
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

        public IAsyncRelayCommand FirstAsyncCommand { get; }

        public IAsyncRelayCommand PreviousAsyncCommand { get; }

        public IAsyncRelayCommand NextAsyncCommand { get; }

        public IAsyncRelayCommand LastAsyncCommand { get; }

        public async Task InitializeAsync()
        {
            // Tạo danh sách đơn đặt hàng ở đây.
            List<Order> orders = CreateOrders();

            // Dùng danh sách đơn đặt hàng để cập nhật dữ liệu
            UpdateData(orders);
        }

        private List<Order> CreateOrders()
        {
            // Tạo và trả về danh sách đơn đặt hàng dựa trên logic của bạn.
            List<Order> orders = new()
            {
                new Order
                {
                    Id = 1,
                    created_at = DateTime.Now,
                    status = true,
                    total = 500
                    // Các thuộc tính khác của đơn đặt hàng
                },
                new Order
                {
                    Id = 2,
                    created_at = DateTime.Now,
                    status = true,
                    total = 500
                    // Các thuộc tính khác của đơn đặt hàng
                },
                new Order
                {
                    Id = 3,
                    created_at = DateTime.Now,
                    status = true,
                    total = 500
                    // Các thuộc tính khác của đơn đặt hàng
                },
                new Order
                {
                    Id = 4,
                    created_at = DateTime.Now,
                    status = true,
                    total = 500
                    // Các thuộc tính khác của đơn đặt hàng
                },
                new Order
                {
                    Id = 5,
                    created_at = DateTime.Now,
                    status = true,
                    total = 500
                    // Các thuộc tính khác của đơn đặt hàng
                },
            };

            return orders;
        }

        private async Task GetOrders(int pageIndex, int pageSize)
        {
            PaginatedList<Order> pagedOrders = await PaginatedList<Order>.CreateAsync(
                _orders,
                pageIndex,
                pageSize);

            PageNumber = pagedOrders.PageIndex;
            PageCount = pagedOrders.PageCount;
            Orders = pagedOrders;
            FirstAsyncCommand.NotifyCanExecuteChanged();
            PreviousAsyncCommand.NotifyCanExecuteChanged();
            NextAsyncCommand.NotifyCanExecuteChanged();
            LastAsyncCommand.NotifyCanExecuteChanged();
        }

        private void UpdateData(List<Order> orders)
        {
            // Cập nhật dữ liệu danh sách đơn đặt hàng
            _pageNumber = 0;
            GetOrders(1, _pageSize);
        }

        private void Refresh()
        {
            _pageNumber = 0;
            FirstAsyncCommand.Execute(null);
        }
    }
}
