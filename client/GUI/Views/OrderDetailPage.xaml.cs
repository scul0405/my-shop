using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Entity;
using GUI.ViewModels;

namespace GUI.Views
{
    public sealed partial class OrderDetailPage : Page
    {
        private OrderDetailPageViewModel viewModel;

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
                ShowSuccessMessage("Cập Nhật Đơn Đặt Hàng Thành Công", "Nhấn OK để chuyển đến Trang Đơn Hàng.");
            }
            else
            {
                ShowFailureMessage("Cập Nhật Đơn Đặt Hàng Thất Bại", viewModel.failMessage);
            }
        }

        private async void DeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            var result = await ShowConfirmDialog();

            if (result)
            {
                ShowSuccessMessage("Xóa Đơn Đặt Hàng Thành Công", "Nhấn OK để chuyển đến Trang Đơn Hàng.");
            }
            else
            {
                ShowFailureMessage("Xóa Đơn Đặt Hàng Thất Bại", viewModel.failMessage);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrdersPage));
        }

        private async Task<bool> ShowConfirmDialog()
        {
            var confirmDialog = new ContentDialog
            {
                Title = "Xóa Đơn Đặt Hàng",
                Content = "Bạn chắc chắn chứ?",
                CloseButtonText = "Hủy",
                PrimaryButtonText = "Xóa"
            };

            confirmDialog.XamlRoot = this.Content.XamlRoot;

            bool result = false;

            confirmDialog.PrimaryButtonClick += (sender, args) =>
            {
                viewModel.DeleteOrderCommand.Execute(null);
                result = viewModel.isDelete;
                if (result)
                {
                    Frame.Navigate(typeof(OrdersPage));
                }
            };

            await confirmDialog.ShowAsync();

            return result;
        }

        private async void ShowSuccessMessage(string title, string msg)
        {
            var successDialog = new ContentDialog
            {
                Title = title,
                Content = msg,
                CloseButtonText = "OK"
            };

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

            failureDialog.XamlRoot = this.Content.XamlRoot;

            await failureDialog.ShowAsync();
        }
    }
}
