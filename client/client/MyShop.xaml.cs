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
using ThreeLayerContract;
using Telerik.Core;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace client
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyShop : Window
    {
        IGUI _gui;
        public MyShop(IGUI gui)
        {
            this.InitializeComponent();
            _gui = gui;
            Load_Gui();
        }

        private void Load_Gui()
        {
            //TODO: Change Code Gui - Login -> GetMainWindow
            var control = _gui.GetMainWindow();

            Content.Children.Add(control);
            Content.Width = control.Width;
            Content.Height = control.Height;

            //MainWindow.DataContext = control;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
