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
using ThreeLayerContract;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Entity;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        Dictionary<string, IBus> _bus = BusInstance._bus;
        List<Book> books;
        List<BookCategory> bookCategories;
        public HomePage()
        {
            this.InitializeComponent();
            //productions.Text = books.Count.ToString();
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            var configurationBook = new Dictionary<string, string> { { "size", "10000" } };
            books = new List<Book>(_bus["Book"].Get(configurationBook));
            productions.Text = books.Count.ToString();


            bookCategories = new List<BookCategory>(_bus["BookCategory"].Get(configurationBook));
            categories.Text = bookCategories.Count.ToString();
        }
    }
}
