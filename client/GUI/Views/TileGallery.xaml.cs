using CommunityToolkit.Mvvm.ComponentModel;
using Entity;
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
using WinRT;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    public sealed partial class TileGallery : UserControl
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
        public TileGallery()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void scroller_ViewChanging(object sender, ScrollViewerViewChangingEventArgs e)
        {
            if (e.FinalView.HorizontalOffset < 1)
            {
                ScrollBackBtn.Visibility = Visibility.Collapsed;
            }
            else if (e.FinalView.HorizontalOffset > 1)
            {
                ScrollBackBtn.Visibility = Visibility.Visible;
            }

            if (e.FinalView.HorizontalOffset > scroller.ScrollableWidth - 1)
            {
                ScrollForwardBtn.Visibility = Visibility.Collapsed;
            }
            else if (e.FinalView.HorizontalOffset < scroller.ScrollableWidth - 1)
            {
                ScrollForwardBtn.Visibility = Visibility.Visible;
            }
        }

        private void ScrollBackBtn_Click(object sender, RoutedEventArgs e)
        {
            scroller.ChangeView(scroller.HorizontalOffset - scroller.ViewportWidth, null, null);
            // Manually focus to ScrollForwardBtn since this button disappears after scrolling to the end.          
            ScrollForwardBtn.Focus(FocusState.Programmatic);
        }

        private void ScrollForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            scroller.ChangeView(scroller.HorizontalOffset + scroller.ViewportWidth, null, null);

            // Manually focus to ScrollBackBtn since this button disappears after scrolling to the end.    
            ScrollBackBtn.Focus(FocusState.Programmatic);
        }

        private void scroller_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateScrollButtonsVisibility();
        }

        private void UpdateScrollButtonsVisibility()
        {
            if (scroller.ScrollableWidth > 0)
            {
                ScrollForwardBtn.Visibility = Visibility.Visible;
            }
            else
            {
                ScrollForwardBtn.Visibility = Visibility.Collapsed;
            }
        }

        public int Productions
        {
            get => _productions;
        }

        public int Categories
        {
            get => _categories;
        }

        public int OrdersMonth
        {
            get => _ordersMonth;
        }

        public int OrdersWeek
        {
            get => _ordersWeek;
        }

        public int OrdersDay
        {
            get => _ordersDay;
        }
        private void LoadData()
        {
            var configurationBook = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            try
            {
                allBooksAvaiable = new List<Book>(_bus["Book"].Get(configurationBook)).Where(book => book.status).ToList();
                _productions = allBooksAvaiable.Count;
            }
            catch
            {
                allBooksAvaiable = new List<Book>();
            }

            try
            {
                allBookCategoriesAvaiable = new List<BookCategory>(_bus["BookCategory"].Get(configurationBook));
                _categories = allBookCategoriesAvaiable.Count;
            }
            catch
            {
                allBookCategoriesAvaiable = new List<BookCategory>();
            }

            try
            {
                allOrdersAvaiable = new List<Order>(_bus["Order"].Get(configurationBook)).Where(order => order.status).ToList();
                _ordersMonth = allOrdersAvaiable.Where(order => order.created_at.Month == DateTime.Now.Month).Count();
                _ordersWeek = allOrdersAvaiable.Where(order => order.created_at.DayOfYear >= DateTime.Now.DayOfYear - 7).Count();
                _ordersDay = allOrdersAvaiable.Where(order => order.created_at.DayOfYear == DateTime.Now.DayOfYear).Count();
            }
            catch
            {
                allOrdersAvaiable = new List<Order>();
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
    }
}
