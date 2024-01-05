using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;
using Entity;
using System.Diagnostics;

namespace GUI.ViewModels
{
    internal class HomePageViewModel : ObservableObject
    {
        private Dictionary<string, IBus> _bus = BusInstance._bus;
        private List<Book> allBooksAvaiable = new List<Book>();
        private List<Order> allOrdersAvaiable = new List<Order>();
        private List<BookCategory> allBookCategoriesAvaiable = new List<BookCategory>();
        private int _productions = 0;
        private int _categories = 0;

        private int _ordersMonth = 0;
        private int _ordersWeek = 0;
        private int _ordersDay = 0;

        private List<Data> _ordersIn7Last7Day = new List<Data>();
        private List<Book> _top5BookBestSeller = new List<Book>();
        private List<Book> _top5BookLowStock = new List<Book>();

        public HomePageViewModel()
        {
            Debug.WriteLine("HomePageViewModel init");
            LoadData();
            foreach(var book in allBooksAvaiable)
            {
                Debug.WriteLine(book.name);
            }
            foreach(var order in allOrdersAvaiable)
            {
                Debug.WriteLine(order.Id);
            }
        }

        public void LoadDataForHomePage()
        {
            LoadData();
            Debug.WriteLine("LoadDataForHomePage");
            LoadDataOrderInLast7Day();
            foreach (var order in OrdersIn7Day)
            {
                Debug.WriteLine(order.Category + " " + order.Value);
            }
            LoadTop5BookBestSeller();
            LoadTop5BookLowStock();
            Debug.WriteLine("Top 5 book best seller");
            foreach (var book in Top5BookBestSeller)
            {
                Debug.WriteLine(book.name);
            }
            Debug.WriteLine("Top 5 book low stock");
            foreach (var book in Top5BooKLowStock)
            {
                Debug.WriteLine(book.name);
            }
        }

        public string MessageProductions
        {
            get => fillMessage("product", Productions);
        }

        public string MessageCategories
        {
            get => fillMessage("category", Categories);
        }

        public string MessageOrdersMonth
        {
            get => fillMessage("order", OrdersMonth, "this month");
        }

        public string MessageOrdersWeek
        {
            get => fillMessage("order", OrdersWeek, "last 7 days");
        }

        public string MessageOrdersDay
        {
            get => fillMessage("order", OrdersDay, "today");
        }
        private string fillMessage(string message, int value, string last = "")
        {
            string msg = "";
            if (message.Equals("category") || message.Equals("product"))
            {
                if (value == 0)
                {
                    msg = "There is no " + message + " available.";
                }
                else if (value == 1)
                {
                    msg = "There is only " + value + " " + message + " available.";
                }
                else
                {
                    if (message.Equals("category"))
                    {
                        msg = "There are " + value + " categories available";
                    }
                    else
                    {
                        msg = "There are " + value + " " + message + " available.";
                    }
                }
            }
            else
            {
                if (value == 0)
                {
                    msg = "There is no " + message + " in" + last + ".";
                }
                else if (value == 1)
                {
                    msg = "There is only " + value + " " + message + " in " + last + ".";
                }
                else
                {
                    msg = "There are " + value + " " + message + "s" + " in " + last + ".";
                }
            }
            return msg;
        }

        public List<Book> Top5BookBestSeller
        {
            get => _top5BookBestSeller;
            set => SetProperty(ref _top5BookBestSeller, value);
        }

        public List<Book> Top5BooKLowStock
        {
            get => _top5BookLowStock;
            set => SetProperty(ref _top5BookLowStock, value);
        }

        private void LoadTop5BookBestSeller()
        {
            try
            {
                // Sắp xếp sách theo số lượng đã bán giảm dần và lấy 5 cuốn đầu tiên
                _top5BookBestSeller = allBooksAvaiable.OrderByDescending(book => book.total_sold).Take(5).ToList();
            }
            catch
            {
                // Xử lý nếu có lỗi khi tải dữ liệu
            }
        }

        private void LoadTop5BookLowStock()
        {
            try
            {
                // Sắp xếp sách theo số lượng còn lại tăng dần và lấy 5 cuốn đầu tiên
                _top5BookLowStock = allBooksAvaiable.OrderBy(book => book.quantity).Take(5).ToList();
            }
            catch
            {
                // Xử lý nếu có lỗi khi tải dữ liệu
            }
        }
        private void LoadDataOrderInLast7Day()
        {
            List<Data> data = new List<Data>();
            for (int i = 0; i < 7; i++)
            {
                List<Order> orders = new List<Order>();
                var configurationBook = new Dictionary<string, string> {
                    { "size", int.MaxValue.ToString() },
                    { "from", DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd") },
                    { "to", DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd") }
                };

                try
                {
                    List<Order> tempOrders = new List<Order>(_bus["Order"].Get(configurationBook)).Where(order => order.status).ToList();
                    if (tempOrders != null)
                    {
                        orders = tempOrders;
                    }
                    data.Add(new Data { Category = DateTime.Now.AddDays(-i).ToString("dd-MM-yyyy"), Value = orders.Count });
                }
                catch
                {
                    Debug.WriteLine("Fail to get order in data base");
                    data.Add(new Data { Category = DateTime.Now.AddDays(-i).ToString("dd-MM-yyyy"), Value = 0 });
                }
            }
            OrdersIn7Day = data;
        }

        public List<Data> OrdersIn7Day
        {
            get 
            {
                Debug.WriteLine("Get OrdersIn7Day");
                return _ordersIn7Last7Day;
            }
            set {
                Debug.WriteLine("Get OrdersIn7Day");
                SetProperty(ref _ordersIn7Last7Day, value);
            } 
        }
        public int Productions
        {
            get => _productions;
            set => SetProperty(ref _productions, value);
        }

        public int Categories
        {
            get => _categories;
            set => SetProperty(ref _categories, value);
        }

        public int OrdersMonth
        {
            get => _ordersMonth;
            set => SetProperty(ref _ordersMonth, value);
        }

        public int OrdersWeek
        {
            get => _ordersWeek;
            set => SetProperty(ref _ordersWeek, value);
        }

        public int OrdersDay
        {
            get => _ordersDay;
            set => SetProperty(ref _ordersDay, value);
        }
        private void LoadData()
        {
            var configurationBook = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            try
            {
                allBooksAvaiable = new List<Book>(_bus["Book"].Get(configurationBook)).Where(book => book.status).ToList();
                Productions = allBooksAvaiable.Count;
            }
            catch
            {
                allBooksAvaiable = new List<Book>();
            }

            try
            {
                allBookCategoriesAvaiable = new List<BookCategory>(_bus["BookCategory"].Get(configurationBook));
                Categories = allBookCategoriesAvaiable.Count;
            }
            catch
            {
                allBookCategoriesAvaiable = new List<BookCategory>();
            }

            try
            {
                allOrdersAvaiable = new List<Order>(_bus["Order"].Get(configurationBook)).Where(order => order.status).ToList();
                OrdersMonth = allOrdersAvaiable.Where(order => order.created_at.Month == DateTime.Now.Month).Count();
                OrdersWeek = allOrdersAvaiable.Where(order => order.created_at.DayOfYear >= DateTime.Now.DayOfYear - 7).Count();
                OrdersDay = allOrdersAvaiable.Where(order => order.created_at.DayOfYear == DateTime.Now.DayOfYear).Count();
            }
            catch
            {
                allOrdersAvaiable = new List<Order>();
            }
        }
    }

}
