﻿using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using GUI.AnimatedVisuals;
using Windows.UI;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginForm : Window
    {
        public LoginForm()
        {
            this.InitializeComponent();
            //SetTitleBar(AppTitleBar);
            ExtendsContentIntoTitleBar = false;
        }

        private void Button_Login_OnClick(object sender, TappedRoutedEventArgs e)
        {
            // Kiểm tra tài khoản và mật khẩu
            string username = TextBoxUser.Text;
            string password = TextBoxPassword.Password;
            if (IsAdminAccount(username, password))
            {
                // Đăng nhập thành công, hiển thị thông báo hoặc chuyển đến trang chính thức
                ShowSuccessMessage();

                // Lưu trạng thái "Remember Password" nếu người dùng chọn
                if (RememberPasswordCheckBox.IsChecked.HasValue &&
                    RememberPasswordCheckBox.IsChecked.Value)
                {
                    SaveRememberPasswordState(true);
                }
                else
                {
                    SaveRememberPasswordState(false);
                }
                
            }
            else
            {
                // Đăng nhập không thành công, hiển thị thông báo hoặc xử lý ngược lại
                ShowFailureMessage();
            }
        }

        private bool IsAdminAccount(string username, string password)
        {
            // Thực hiện kiểm tra tài khoản và mật khẩu ở đây
            return username == "admin" && password == "admin";
        }

        private async void ShowSuccessMessage()
        {
            var successDialog = new ContentDialog
            {
                Title = "Login Successful",
                Content = "Welcome, Admin!",
                CloseButtonText = "OK"
            };

            if (successDialog.XamlRoot != null)
            {
                successDialog.XamlRoot = null;
            }

            successDialog.XamlRoot = this.Content.XamlRoot;

            successDialog.Closed += (sender, args) =>
            {
                NavigateToDashboard();
            };

            await successDialog.ShowAsync();
        }


        private async void ShowFailureMessage()
        {
            // Hiển thị thông báo đăng nhập không thành công
            var failureDialog = new ContentDialog
            {
                Title = "Login Failed",
                Content = "Invalid username or password.",
                CloseButtonText = "OK"
            };

            if (failureDialog.XamlRoot != null)
            {
                failureDialog.XamlRoot = null;
            }

            failureDialog.XamlRoot = this.Content.XamlRoot;

            await failureDialog.ShowAsync();
        }

        private void SaveRememberPasswordState(bool isRemembered)
        {
            // Lưu trạng thái "Remember Password" vào ApplicationData
            Windows.Storage.ApplicationDataContainer localSettings =
                Windows.Storage.ApplicationData.Current.LocalSettings;

            localSettings.Values["RememberPassword"] = isRemembered;
        }

        private void NavigateToDashboard()
        {
            Dashboard dashboardWindow = new Dashboard();


            Frame frame = new Frame();

            // Chuyển hướng sang trang Dashboard
            frame.Navigate(typeof(Dashboard));

            // Gán frame làm nội dung cho cửa sổ hiện tại
            this.Content = frame;

        }
    }
}
