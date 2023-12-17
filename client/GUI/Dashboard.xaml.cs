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

namespace GUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Dashboard : Window
    {
        public Dashboard()
        {
            this.InitializeComponent();
            contentFrame.Navigate(typeof(HomePage));
        }

        private void navView_SelectionChange(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            FrameNavigationOptions navOptions = new FrameNavigationOptions();

            navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;

            if (sender.PaneDisplayMode == NavigationViewPaneDisplayMode.Top)

            {

                navOptions.IsNavigationStackEnabled = false;

            }

            Type pageType = typeof(HomePage); //init



            var selectedItem = (NavigationViewItem)args.SelectedItem;

            if (selectedItem.Name == navItem_HomePage.Name)

            {

                pageType = typeof(HomePage);

            }

            else if (selectedItem.Name == navItem_SettingPage.Name)

            {

                pageType = typeof(SettingPage);

            }

            _ = contentFrame.Navigate(pageType);// .NavigateToType(pageType, null, navOptions);
        }
    }
}
