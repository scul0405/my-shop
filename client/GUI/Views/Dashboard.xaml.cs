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
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Dashboard : Window
    {
        private SettingViewModel settingsViewModel = new SettingViewModel();
        public Dashboard()
        {
            this.InitializeComponent();
            SetInitialPage();
            nvSample.SelectionChanged += NavigationView_SelectionChanged;
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                contentFrame.Navigate(typeof(SettingPage));
                return;
            }

            if (args.SelectedItemContainer != null)
            {
                switch (args.SelectedItemContainer.Tag)
                {
                    case "NavItem_HomePage":
                        contentFrame.Navigate(typeof(HomePage));
                        break;

                    case "NavItem_OrdersPage":
                        contentFrame.Navigate(typeof(OrdersPage));
                        break;

                    case "NavItem_ProductsPage":
                        contentFrame.Navigate(typeof(ProductsPage));
                        break;
                    // Add more cases for other pages as needed

                    default:
                        break;
                }
            }
        }

        private void SetInitialPage()
        {
            // Chọn trang mặc định là HomePage
            contentFrame.Navigate(typeof(HomePage));
            NavItem_HomePage.IsSelected = true;
        }

        private void UpdateAppTheme()
        {
            string themeMode;
            if (settingsViewModel == null)
            {
                themeMode = "Default";
            } else
            {
                themeMode = settingsViewModel.SelectedTheme;
            }

            if (themeMode == null)
            {
                themeMode = "Default";
            }

            switch (themeMode)
            {
                case "Default":
                    Application.Current.RequestedTheme = ApplicationTheme.Light; // Set a default theme if needed
                    break;

                case "Light":
                    Application.Current.RequestedTheme = ApplicationTheme.Light;
                    break;

                case "Dark":
                    Application.Current.RequestedTheme = ApplicationTheme.Dark;
                    break;
            }
        }

    }
}
