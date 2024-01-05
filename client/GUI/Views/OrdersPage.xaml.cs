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
            ScreenStateManager.SaveLastScreen("OrdersPage");
            FromDatePicker.MaxYear = DateTime.Now;
            ToDatePicker.MaxYear = DateTime.Now;

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

                try
                {
                    myOrder = _bus["Order"].Get(configuration);
                } catch
                {
                    //eat
                }               

                if (myOrder == null)
                {
                    Debug.WriteLine("Order is null");
                }
                else if (myOrder.books != null)
                {
                    foreach (var item in myOrder.books)
                    {
                        try
                        {
                            Book book = new Book();
                            book = ConvertToSpecificBook(item);
                            books.Add(book);
                            Debug.WriteLine("Book id " + book.ID);
                        }
                        catch
                        {
                            Debug.WriteLine("Book is null or cant ConvertToSpecificBook");
                            //eat
                        }

                    }
                }
                Frame.Navigate(typeof(OrderDetailPage), Tuple.Create(ID, books));
            }
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

        private void ClearFilter_Click(object sender, RoutedEventArgs e)
        {
            FromDatePicker.SelectedDate = null;
            ToDatePicker.SelectedDate = null;
            ViewModel.ClearFilter();
        }

        private void DatePicker_SelectedDateChanged(DatePicker sender, DatePickerSelectedValueChangedEventArgs args)
        {
            try
            {
                if (sender == FromDatePicker)
                {
                    ViewModel.FromDate = args.NewDate.Value.DateTime;
                }
                else if (sender == ToDatePicker)
                {
                    ViewModel.ToDate = args.NewDate.Value.DateTime;
                }
            } catch
            {
                //eat
            }

        }
    }
}
