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

        private async void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var createOrderDialog = new ContentDialog()
            {
                Title = "Create Order",
                CloseButtonText = "Cancel"
            };
            createOrderDialog.Content = new CreateOrderDialog();
            createOrderDialog.XamlRoot = this.Content.XamlRoot;
            await createOrderDialog.ShowAsync();
        }
    }
}
