using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;
using Entity;
using Microsoft.UI.Xaml.Media;
using Telerik.UI.Xaml.Controls.Chart;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace GUI.ViewModels
{
    class ReportPageViewModel : ObservableObject
    {
        private ObservableCollection<string> filterOptions;
        private Dictionary<string, IBus> _bus = BusInstance._bus;
        private DateTime _fromDate = DateTime.Now.AddDays(-7);
        private DateTime _toDate = DateTime.Now;
        private int selectedFilterIndex = 0;
        // 0 - By Day, 1 - By Week, 2 - By Month, 3 - By Year

        private List<Data> _profit = new List<Data>();
        private List<Data> _revenue = new List<Data>();


        public List<Data> Revenue
        {
            get => _revenue;
            set
            {
                if (value != null)
                {
                    _revenue = value;
                    OnPropertyChanged(nameof(Revenue));
                }
            }
        }

        public List<Data> Profit
        {
            get => _profit;
            set
            {
                if (value != null)
                {
                    _profit = value;
                    OnPropertyChanged(nameof(Profit));
                }
            }
        }

        public ReportPageViewModel()
        {
            FilterOptions = new ObservableCollection<string>
            {
                "By Day",
                "By Week",
                "By Month",
                "By Year"
            };
            RefreshData();

        }

        public void RefreshData()
        {
            Debug.WriteLine("[RefreshData]: Refreshing data...");

            Revenue = GetRevenueData(FromDate, ToDate, selectedFilterIndex); 
            Profit = GetProfitData();    
        }


        private List<Data> GetRevenueData(DateTime from, DateTime to, int index)
        {
            var newData = new List<Data>();

            switch (index)
            {
                // Theo ngày
                case 0:
                    for (DateTime i = from; i <= to; i = i.AddDays(1))
                    {
                        try
                        {
                            List<Order> orders = GetOrdersFromInput(i, i);
                            double revenue = GetRevenueFromOrderList(orders);
                            newData.Add(new Data { Category = i.ToString("yyyy-MM-dd"), Value = revenue });
                        }
                        catch
                        {
                            newData.Add(new Data { Category = i.ToString("yyyy-MM-dd"), Value = 0 });
                        }
                    }
                    break;
                // Theo tuần
                case 1:
                    // quy ước của .NET: 0 -> 6 lần lượt là từ chủ nhật đến thứ bảy
                    // Ta sẽ cho tuần đầu tiên bắt đầu từ nó cho đến thứ hai gần nó nhất
                    // Ví dụ: 2021-09-01 là thứ tư -> tuần đầu tiên sẽ bắt đầu từ 2021-08-29 -> 2021-09-04
                    DateTime startWeek = GetNextMonday(from);

                    // Tính số ngày còn lại trong tuần đầu tiên
                    int remainingDaysInFirstWeek = (int)(startWeek.AddDays(6) - from).TotalDays;

                    // Xử lý tuần đầu tiên
                    try
                    {
                        List<Order> ordersFirstWeek = GetOrdersFromInput(from, startWeek.AddDays(remainingDaysInFirstWeek));
                        double revenueFirstWeek = GetRevenueFromOrderList(ordersFirstWeek);
                        newData.Add(new Data { Category = "Week 1", Value = revenueFirstWeek });
                    }
                    catch
                    {
                        newData.Add(new Data { Category = "Week 1", Value = 0 });
                    }
                    int week = 2;
                    // Tính toán các tuần tiếp theo
                    DateTime weekStart = startWeek.AddDays((remainingDaysInFirstWeek == 6) ? 7 : remainingDaysInFirstWeek + 1);

                    while (weekStart <= to)
                    {
                        DateTime weekEnd = weekStart.AddDays(6);

                        // Tính toán ngày cuối cùng của tuần cuối cùng
                        if (weekEnd > to)
                        {
                            weekEnd = to;
                        }

                        try
                        {
                            List<Order> orders = GetOrdersFromInput(weekStart, weekEnd);
                            double revenue = GetRevenueFromOrderList(orders);
                            newData.Add(new Data { Category = $"Week {week}", Value = revenue });
                        }
                        catch
                        {
                            newData.Add(new Data { Category = $"Week {week}", Value = 0 });
                        }

                        // Chuyển sang tuần tiếp theo
                        weekStart = weekEnd.AddDays(1);
                        week++;
                    }
                    break;
                case 2:
                    DateTime startMonth = new DateTime(from.Year, from.Month, 1);
                    DateTime endMonth = new DateTime(from.Year, from.Month, DateTime.DaysInMonth(from.Year, from.Month));

                    // Xử lý tháng đầu tiên
                    try
                    {
                        List<Order> ordersFirstMonth = GetOrdersFromInput(from, endMonth);
                        double revenueFirstMonth = GetRevenueFromOrderList(ordersFirstMonth);
                        newData.Add(new Data { Category = from.ToString("yyyy-MM"), Value = revenueFirstMonth });
                    }
                    catch
                    {
                        newData.Add(new Data { Category = from.ToString("yyyy-MM"), Value = 0 });
                    }

                    int month = 2;
                    // Tính toán các tháng tiếp theo
                    DateTime monthStart = new DateTime(from.Year, from.Month, 1).AddMonths(1);

                    while (monthStart <= to)
                    {
                        DateTime monthEnd = new DateTime(monthStart.Year, monthStart.Month, DateTime.DaysInMonth(monthStart.Year, monthStart.Month));

                        // Tính toán ngày cuối cùng của tháng cuối cùng
                        if (monthEnd > to)
                        {
                            monthEnd = to;
                        }

                        try
                        {
                            List<Order> orders = GetOrdersFromInput(monthStart, monthEnd);
                            double revenue = GetRevenueFromOrderList(orders);
                            newData.Add(new Data { Category = monthStart.ToString("yyyy-MM"), Value = revenue });
                        }
                        catch
                        {
                            newData.Add(new Data { Category = monthStart.ToString("yyyy-MM"), Value = 0 });
                        }

                        // Chuyển sang tháng tiếp theo
                        monthStart = monthEnd.AddDays(1);
                        month++;
                    }
                    break;

                case 3:
                    DateTime startYear = new DateTime(from.Year, 1, 1);
                    DateTime endYear = new DateTime(from.Year, 12, 31);

                    // Xử lý năm đầu tiên
                    try
                    {
                        List<Order> ordersFirstYear = GetOrdersFromInput(from, endYear);
                        double revenueFirstYear = GetRevenueFromOrderList(ordersFirstYear);
                        newData.Add(new Data { Category = from.Year.ToString(), Value = revenueFirstYear });
                    }
                    catch
                    {
                        newData.Add(new Data { Category = from.Year.ToString(), Value = 0 });
                    }

                    int year = from.Year + 1;
                    // Tính toán các năm tiếp theo
                    DateTime yearStart = new DateTime(from.Year + 1, 1, 1);

                    while (yearStart <= to)
                    {
                        DateTime yearEnd = new DateTime(yearStart.Year, 12, 31);

                        // Tính toán ngày cuối cùng của năm cuối cùng
                        if (yearEnd > to)
                        {
                            yearEnd = to;
                        }

                        try
                        {
                            List<Order> orders = GetOrdersFromInput(yearStart, yearEnd);
                            double revenue = GetRevenueFromOrderList(orders);
                            newData.Add(new Data { Category = $"Year {year}", Value = revenue });
                        }
                        catch
                        {
                            newData.Add(new Data { Category = $"Year {year}", Value = 0 });
                        }

                        // Chuyển sang năm tiếp theo
                        yearStart = yearEnd.AddDays(1);
                        year++;
                    }
                    break;

                default:
                    break;
            }

            return newData;
        }

        private DateTime GetNextMonday(DateTime date)
        {
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)date.DayOfWeek + 7) % 7;
            return date.AddDays(daysUntilMonday);
        }


        private List<Order> GetOrdersFromInput(DateTime from, DateTime to)
        {
            List<Order> orders;
            Dictionary<string, IBus> _bus = BusInstance._bus;
            var configuration = new Dictionary<string, string> {
                { "size", int.MaxValue.ToString() },
                { "from", from.ToString("yyyy-MM-dd")},
                { "to", to.ToString("yyyy-MM-dd")}
            };
            try
            {
                orders = new List<Order>(_bus["Order"].Get(configuration));
            }
            catch
            {
                orders = new List<Order>();
            }
            return orders;
        }

        private double GetRevenueFromOrderList(List<Order> orders)
        {
            double res = 0;
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    if (order.status != false)
                    {
                        res += order.total;
                    }
                }
            }
            return res;
        }

        private List<string> GetCategoryFromInput(DateTime from, DateTime to, int index)
        {
            List<string> categories = new List<string>();
            return categories;
        }

        private List<Data> GetProfitData()
        {
            var newProfit = new List<Data>();

            Random random = new Random();

            foreach (Data revenueData in Revenue)
            {
                // Lấy giá trị a từ 70 đến 80
                double randomPercentage = GetRandomValue(0.7, 0.8);

                // Tính toán giá trị mới cho Profit
                double newProfitValue = revenueData.Value * randomPercentage;

                // Thêm dữ liệu mới vào newProfit
                newProfit.Add(new Data { Category = revenueData.Category, Value = newProfitValue });
            }

            return newProfit;
        }

        private double GetRandomValue(double minValue, double maxValue)
        {
            Random random = new Random();
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }

        public int SelectedFilterIndex
        {
            get { return selectedFilterIndex; }
            set
            {
                if (selectedFilterIndex != value)
                {
                    selectedFilterIndex = value;
                    OnPropertyChanged(nameof(SelectedFilterIndex));
                    RefreshData();
                    Debug.WriteLine("[SelectedFilterIndex]: Change, val: " + selectedFilterIndex);
                }
            }
        }

        public ObservableCollection<string> FilterOptions
        {
            get { return filterOptions; }
            set
            {
                if (filterOptions != value)
                {
                    filterOptions = value;
                    OnPropertyChanged(nameof(FilterOptions));
                }
            }
        }

        public void ClearFilter()
        {
            Debug.WriteLine("[ClearFilter]: onlick");
            // Xóa bộ lọc và cập nhật dữ liệu
            FromDate = DateTime.Now.AddDays(-7);
            ToDate = DateTime.Now;
            SelectedFilterIndex = 0;

            // Gọi Refresh để cập nhật dữ liệu mới
            //Refresh();
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
                    RefreshData();
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
                    RefreshData();
                }
            }
        }

    }

    public class Data
    {
        public string Category { get; set; }

        public double Value { get; set; }
    }

    public class CustomPalettes
    {
        static CustomPalettes()
        {
            CreateCustomDarkPalette();
        }

        private static void CreateCustomDarkPalette()
        {
            ChartPalette palette = new ChartPalette() { Name = "CustomDark" };

            // fill 
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 40, 152, 228)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 205, 0)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 60, 0)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 210, 202, 202)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 67, 67, 67)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 156)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 109, 49, 255)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 178, 161)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 109, 255, 0)));
            palette.FillEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 128, 0)));

            // stroke 
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 96, 194, 255)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 225, 122)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 108, 79)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 229, 229, 229)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 84, 84, 84)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 156)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 130, 79, 255)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 69, 204, 191)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 185, 255, 133)));
            palette.StrokeEntries.Brushes.Add(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 175, 94)));

            CustomDark = palette;
        }

        public static ChartPalette CustomDark { get; private set; }

    }
}
