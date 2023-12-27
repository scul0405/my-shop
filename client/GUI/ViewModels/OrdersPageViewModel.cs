using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Entity;
using GUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    public class OrdersPageViewModel : ObservableObject
    {
        private int _pageSize = 10;
        private int _pageNumber;
        private int _pageCount;
        private List<Order> _orders;
        private List<Order> _allOrders;

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
            // đổ dữ liệu vào allOrders
            _allOrders = CreateOrders();
            GetOrders(1, _pageSize);
        }

        private List<Order> CreateOrders()
        {
            List<Order> orders = new List<Order>();
            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                Order order = new Order
                {
                    Id = i,
                    created_at = DateTime.Now.AddDays(-random.Next(1, 365)),
                    status = random.Next(0, 2) == 0,
                    total = random.Next(100, 1000)
                };

                orders.Add(order);
            }

            return orders;
        }

        private void GetOrders(int pageIndex, int pageSize)
        {
            PaginatedList<Order> pagedOrders = PaginatedList<Order>.Create(
                _allOrders,
                pageIndex,
                pageSize);

            PageNumber = pagedOrders.PageIndex;
            PageCount = pagedOrders.PageCount;
            Orders = pagedOrders;
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
    }
}
