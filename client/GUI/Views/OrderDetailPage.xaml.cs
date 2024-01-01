using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Entity;
using System.Diagnostics;
using GUI.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderDetailPage : Page
    {
        OrderDetailPageViewModel viewModel;
        public OrderDetailPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Tuple<string, List<Book>> tuple)
            {
                viewModel = new OrderDetailPageViewModel(tuple.Item2, tuple.Item1);
            }
            DataContext = viewModel;
        }

        private void UpdateOrder_Click(object sender, RoutedEventArgs e)
        {
            viewModel.UpdateOrderCommand.Execute(null);
            Debug.WriteLine("SaveOrder_Click " + viewModel.isSave);
            if (viewModel.isSave)
            {
                ShowSuccessMessage("Update Order Successful", "Click OK to negative to OrderPage.");
            }
            else
            {
                ShowFailureMessage("Update Order Failed", viewModel.failMessage);
            }
        }

        private void DeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            ShowConfirmDialog();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrdersPage));
        }

        private async void ShowConfirmDialog()
        {
            var confirmDialog = new ContentDialog
            {
                Title = "Delete Order",
                Content = "Are you sure about that?",
                CloseButtonText = "Cancel",
                PrimaryButtonText = "Delete"
            };

            confirmDialog.XamlRoot = this.Content.XamlRoot;

            confirmDialog.PrimaryButtonClick += (sender, args) =>
            {
                viewModel.DeleteOrderCommand.Execute(null);
            };

            await confirmDialog.ShowAsync();
        }

        private async void ShowSuccessMessage(string title, string msg)
        {
            var successDialog = new ContentDialog
            {
                Title = title,
                Content = msg,
                CloseButtonText = "OK"
            };

            if (successDialog.XamlRoot != null)
            {
                successDialog.XamlRoot = null;
            }

            successDialog.XamlRoot = this.Content.XamlRoot;

            successDialog.Closed += (sender, args) =>
            {
                Frame.Navigate(typeof(OrdersPage));
            };

            await successDialog.ShowAsync();
        }

        private async void ShowFailureMessage(string title, string msg)
        {
            var failureDialog = new ContentDialog
            {
                Title = title,
                Content = msg,
                CloseButtonText = "OK"
            };

            if (failureDialog.XamlRoot != null)
            {
                failureDialog.XamlRoot = null;
            }

            failureDialog.XamlRoot = this.Content.XamlRoot;

            await failureDialog.ShowAsync();
        }
    }
}
