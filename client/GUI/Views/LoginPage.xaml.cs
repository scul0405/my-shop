﻿using Microsoft.UI.Xaml;
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
using Windows.Storage;
using ThreeLayerContract;
using Entity;
using System.Diagnostics;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{

    //TODO: Kiểm tra xem mật khẩu đã thật sự được lưu hay chưa, đã hash hay chưa.
    // Nếu người dùng check remember -> lưu và mã hóa mật khẩu.
    // Lần tiếp theo đăng nhập thì hiển thị sẵn TK và MK đã lưu, và check remember.
    // Nếu người dùng sử dụng lại TK và MK cũ, không check remember -> xóa mật khẩu đã lưu.
    // Nếu người dùng sử dụng lại TK và MK cũ, check remember -> không làm gì cả.
    // Nếu người dùng không dùng lại TK và MK cũ, check remember -> lưu và mã hóa mật khẩu, xóa mật khẩu cũ.
    // Nếu người dùng không dùng lại TK và MK cũ, không check remember -> không làm gì cả

    public sealed partial class LoginPage : UserControl
    {
        private bool isLoginInProgress = false;
        private bool isShowDialogProgress = false;
        int click = 0;

        Dictionary<string, IBus> _bus = BusInstance._bus;
        public LoginPage(Dictionary<string, IBus> bus)
        {
            BusInstance._bus = bus;
            this.InitializeComponent();
            LoadRememberedCredentials();
        }
        private void Button_Login_OnClick(object sender, TappedRoutedEventArgs e)
        {
            click++;
            Debug.WriteLine("[LOGIN BUTTON] click: " + click);
            Debug.WriteLine("[LOGIN BUTTON] isLoginInProgress: " + isLoginInProgress);
            if (isLoginInProgress)
            {
                // Nếu đang trong quá trình đăng nhập, không làm gì cả
                return;
            }

            isLoginInProgress = true;

            // Kiểm tra tài khoản và mật khẩu
            string username = TextBoxUser.Text;
            string password = TextBoxPassword.Password;
            if (IsAdminAccount(username, password))
            {
                Debug.WriteLine("[LOGIN BUTTON] isShowDialogProgress before: " + isShowDialogProgress);
                // Đăng nhập thành công, hiển thị thông báo hoặc chuyển đến trang chính thức
                if (isShowDialogProgress == false)
                {
                    isShowDialogProgress = true;
                    ShowSuccessMessage();
                }
                Debug.WriteLine("[LOGIN BUTTON] isShowDialogProgress after: " + isShowDialogProgress);

                // Lưu trạng thái "Remember Password" nếu người dùng chọn
                if (RememberPasswordCheckBox.IsChecked.HasValue &&
                    RememberPasswordCheckBox.IsChecked.Value)
                {
                    Debug.WriteLine("Is checked");
                    SaveRememberPasswordState(true, TextBoxUser.Text, TextBoxPassword.Password);
                }
                else
                {
                    SaveRememberPasswordState(false, "", "");
                }
            }
            else
            {
                // Đăng nhập không thành công, hiển thị thông báo hoặc xử lý ngược lại
                if (isShowDialogProgress == false)
                {
                    isShowDialogProgress = true;
                    ShowFailureMessage();
                }
            }
            isLoginInProgress = false;
            Debug.WriteLine("[LOGIN BUTTON] isShowDialogProgress last: " + isShowDialogProgress);
        }

        private bool IsAdminAccount(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            // Thực hiện kiểm tra tài khoản và mật khẩu ở đây
            bool flag = false;
            Dictionary<string, IBus> _bus = BusInstance._bus;
            var configuration = new Dictionary<string, string> {
                { "type", "login" },
            };
            User user = new User();
            user.username = username;
            user.password = password;

            flag = _bus["User"].Post(user, configuration);

            // Để sử dụng tài khoản mặc định, hãy thay đổi flag thành true
            // return flag;
            return flag;
        }

        private async void ShowSuccessMessage()
        {
            // Hiển thị thông báo đăng nhập thành công
            var successDialog = new ContentDialog
            {
                Title = "Login Successful",
                Content = "Welcome, Admin!",
                CloseButtonText = "OK"
            };

            successDialog.Closed += (sender, args) =>
            {
                // Thực hiện hành động sau khi đóng dialog (ví dụ: chuyển đến trang Dashboard)
                NavigateToDashboard();
            };

            if (successDialog.XamlRoot != null)
            {
                successDialog.XamlRoot = null;
            }

            successDialog.XamlRoot = this.Content.XamlRoot;

            await successDialog.ShowAsync().AsTask();
            isShowDialogProgress = false;
            Debug.WriteLine("[ShowSuccessMessage] isShowDialogProgress after: " + isShowDialogProgress);
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

            await failureDialog.ShowAsync().AsTask();
            isShowDialogProgress = false;
        }

        private void SaveRememberPasswordState(bool isRemembered, string username, string password)
        {
            // Lưu trạng thái "Remember Password" vào ApplicationData
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["RememberPassword"] = isRemembered;

            // Nếu người dùng chọn nhớ mật khẩu, lưu thông tin tài khoản và mật khẩu vào LocalSettings
            if (isRemembered)
            {
                localSettings.Values["Username"] = username;
                localSettings.Values["Password"] = password;
            }
            else // Nếu không nhớ mật khẩu, xóa thông tin trong LocalSettings
            {
                localSettings.Values["Username"] = null;
                localSettings.Values["Password"] = null;
            }
        }

        private void LoadRememberedCredentials()
        {
            // Tải thông tin tài khoản và mật khẩu từ LocalSettings nếu có
            var localSettings = ApplicationData.Current.LocalSettings;
            var username = localSettings.Values["Username"] as string;
            var password = localSettings.Values["Password"] as string;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                TextBoxUser.Text = username;
                TextBoxPassword.Password = password;
                RememberPasswordCheckBox.IsChecked = true;
            }
        }


        private void NavigateToDashboard()
        {
            // Thực hiện chuyển hướng sang trang Dashboard
            Dashboard dashboardWindow = new Dashboard();

            Frame frame = new Frame();

            // Chuyển hướng sang trang Dashboard
            frame.Navigate(typeof(Dashboard));

            // Gán frame làm nội dung cho cửa sổ hiện tại
            this.Content = frame;
        }

        private void NavigateToLastScreen()
        {
            string lastScreen = ScreenStateManager.GetLastScreen();
            switch (lastScreen)
            {
                case "Dashboard":
                    NavigateToDashboard();
                    break;
                case "OrdersPage":
                    {
                        Frame frame = new Frame();
                        frame.Navigate(typeof(OrdersPage));
                        this.Content = frame;
                        break;
                    }
                case "ProductsPage":
                    {
                        Frame frame = new Frame();
                        frame.Navigate(typeof(ProductsPage));
                        this.Content = frame;
                        break;
                    }
                case "ReportPage":
                    {
                        Frame frame = new Frame();
                        frame.Navigate(typeof(ReportPage));
                        this.Content = frame;
                        break;
                    }
                case "SettingPage":
                    {
                        Frame frame = new Frame();
                        frame.Navigate(typeof(SettingPage));
                        this.Content = frame;
                        break;
                    }
                case "HomePage":
                    {
                        NavigateToDashboard();
                        break;
                    }
                case "CreateOrderPage":
                    {
                        Frame frame = new Frame();
                        frame.Navigate(typeof(CreateOrderPage));
                        this.Content = frame;
                        break;
                    }
                default:
                    NavigateToDashboard();
                    break;
            }
        }
    }
}