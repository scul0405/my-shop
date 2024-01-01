using GUI.ViewModels;
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
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Diagnostics;
using Entity;
using ThreeLayerContract;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            Loaded += OrdersPage_Loaded;
        }

        private void OrdersPage_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.InitializeAsync();
        }

        private OrdersPageViewModel ViewModel => DataContext as OrdersPageViewModel;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateOrderPage));
        }

        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var order = button?.DataContext as Order;

            if (order != null)
            {
                // Chuyển hướng đến trang Detail và chuyển đối tượng Order qua trang đó
                List<Book> books = new List<Book>();
                string ID = order.Id.ToString();
                var configuration = new Dictionary<string, string> { { "id", ID } };
                Dictionary<string, IBus> _bus = BusInstance._bus;
                Order myOrder = new Order();
                myOrder = _bus["Order"].Get(configuration);

                foreach (var book in myOrder.books)
                {
                    books.Add(book);
                }
                foreach(var book in books)
                {
                    Debug.WriteLine("DetailButton_Click: book: " + book.name);
                }
                Frame.Navigate(typeof(OrderDetailPage), order);
            }
        }
    }
}
