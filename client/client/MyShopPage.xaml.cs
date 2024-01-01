using GUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ThreeLayerContract;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace client
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyShopPage : Page
    {
        private IGUI _gui;

        public MyShopPage()
        {
            this.InitializeComponent();
        }

        private void Load_Gui()
        {
            var control = _gui.GetMainWindow();

            Content.Children.Add(control);
            Content.Width = control.Width;
            Content.Height = control.Height;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is IGUI gui)
            {
                Debug.WriteLine("MyShopPageData received successfully.");
                _gui = gui;
            } else
            {
                Debug.WriteLine("Unexpected parameter type: " + e.Parameter.GetType());
            }
            Load_Gui();
        }
    }

}
