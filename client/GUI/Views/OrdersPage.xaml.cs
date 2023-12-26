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
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class OrdersPage : Page
    {
        public ObservableCollection<Order> Orders { get; set; }
        public OrdersPage()
        {
            this.InitializeComponent();
            Orders = new ObservableCollection<Order>();

            // Thêm dữ liệu mẫu
            Orders.Add(new Order { Id = 1, created_at = DateTime.Now, total = 50, status = true });
            Orders.Add(new Order { Id = 2, created_at = DateTime.Now.AddDays(-1), total = 75, status = false });
            Orders.Add(new Order { Id = 3, created_at = DateTime.Now.AddDays(-2), total = 120, status = true });

            // Gán nguồn dữ liệu cho DataGrid
            OrdersDataGrid.ItemsSource = Orders;
        }

        private async void OrdersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrdersDataGrid.SelectedItem is Order selectedOrder)
            {
                OrderDetailPage orderDetailDialog = new OrderDetailPage();
                orderDetailDialog.Order = selectedOrder;
                if (orderDetailDialog.XamlRoot != null)
                {
                    orderDetailDialog.XamlRoot = null;
                }

                orderDetailDialog.XamlRoot = this.Content.XamlRoot;

                await orderDetailDialog.ShowAsync();
            }
        }
    }
}
