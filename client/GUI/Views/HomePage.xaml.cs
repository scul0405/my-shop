using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ThreeLayerContract;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        Dictionary<string, IBus> _bus = BusInstance._bus;
        List<Book> books;
        List<BookCategory> bookCategories;
        List<Order> ordersMonth;
        List<Order> ordersWeek;
        public HomePage()
        {
            this.InitializeComponent();
            //productions.Text = books.Count.ToString();
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            var configurationBook = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            try
            {
                //books = new List<Book>(_bus["Book"].Get(configurationBook));
                books = new List<Book>(_bus["Book"].Get(configurationBook)).Where(book => book.status).ToList();
                productions.Text = books.Count.ToString();
            }
            catch
            {
                books = new List<Book>();
                productions.Text = "0";
            }

            try
            {
                bookCategories = new List<BookCategory>(_bus["BookCategory"].Get(configurationBook));
                categories.Text = bookCategories.Count.ToString();
            }
            catch
            {
                categories.Text = "0";
            }


            //Handle chart numbers
            DateTime currentDate = DateTime.Now;
            string curDateStr = currentDate.ToString("yyyy-MM-dd");
            string currentDay = currentDate.Day.ToString();
            string currentMonth = currentDate.Month.ToString();
            string currentYear = currentDate.Year.ToString();
            var configOrderMonth = new Dictionary<string, string>
                        { { "from", $"{currentYear}-{currentMonth}-{1}" },
                          { "to", $"{currentYear}-{currentMonth}-{currentDay}" },
                          {"size", int.MaxValue.ToString() }};

            try
            {
                ordersMonth = new List<Order>(_bus["Order"].Get(configOrderMonth));
                ordersM.Text = ordersMonth.Count.ToString();
            }
            catch
            {
                ordersM.Text = "0";
            }

            int currentDayOfWeek = ((int)currentDate.DayOfWeek);
            string firstDayWeek = currentDate.AddDays(-currentDayOfWeek + 1).ToString("yyyy-MM-dd");
            var configOrderWeek = new Dictionary<string, string>
                        { { "from", $"{firstDayWeek}" },
                          { "to", $"{currentYear}-{currentMonth}-{currentDay}" },
                          {"size", int.MaxValue.ToString() } };

            try
            {
                ordersWeek = new List<Order>(_bus["Order"].Get(configOrderWeek));
                ordersW.Text = ordersWeek.Count.ToString();
            }
            catch
            {
                ordersW.Text = "0";
            }

            bookQuantity.ItemsSource = books.OrderBy(book => book.quantity).Take(5).ToList();
            bookBestSel.ItemsSource = books.OrderByDescending(book => book.total_sold).Take(5).ToList();
            string preDay = currentDate.AddDays(-1).ToString("yyyy-MM-dd");

            List<Data> data = new List<Data>();
            data.Add(new Data() { Category = "Sunday", Value = 0 });
            data.Add(new Data() { Category = "Monday", Value = 0 });
            data.Add(new Data() { Category = "Tuesday", Value = 0 });
            data.Add(new Data() { Category = "Wednesday", Value = 0 });
            data.Add(new Data() { Category = "Thursday", Value = 0 });
            data.Add(new Data() { Category = "Friday", Value = 0 });
            data.Add(new Data() { Category = "Saturday", Value = 0 });
            
            for (int i = 0; i <= currentDayOfWeek; i++)
            {
                var configDayOrder = new Dictionary<string, string>
                        { { "from", $"{currentDate.AddDays(+i-currentDayOfWeek).ToString("yyyy-MM-dd")}" },
                          { "to", $"{currentDate.AddDays(+i-currentDayOfWeek).ToString("yyyy-MM-dd")}" },
                          {"size", int.MaxValue.ToString() } };
                //List<Order> temp = new List<Order>();
                try
                {
                    var temp = new List<Order>(_bus["Order"].Get(configDayOrder));
                    data[i].Value = temp.Count();
                }
                catch
                {
                    continue;
                }
            }
            
            this.lineSeries.DataContext = data;
        }
        public class Data
        {
            public string Category { get; set; }

            public double Value { get; set; }

        }
    }
}
