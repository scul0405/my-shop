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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    public sealed partial class CreateOrderPage : Page
    {
        CreateOrderViewModel viewModel = new CreateOrderViewModel();
        public CreateOrderPage()
        {
            this.InitializeComponent();
            this.DataContext = viewModel;
            ScreenStateManager.SaveLastScreen("CreateOrderPage");
        }

        private void SaveOrder_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SaveOrderCommand.Execute(null);
            Debug.WriteLine("SaveOrder_Click " + viewModel.isSave);
            if (viewModel.isSave)
            {
                ShowSuccessMessage();
            }
            else
            {
                ShowFailureMessage(viewModel.failMessage);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrdersPage));
        }

        private async void ShowSuccessMessage()
        {
            var successDialog = new ContentDialog
            {
                Title = "Create Order Successful",
                Content = "Click OK to navigate to OrderPage",
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

        private async void ShowFailureMessage(string msg)
        {
            var failureDialog = new ContentDialog
            {
                Title = "Create Order Failed",
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