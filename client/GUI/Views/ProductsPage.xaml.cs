using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Collections.ObjectModel;
using CommunityToolkit.WinUI.UI.Controls;
using Entity;
using GUI.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductsPage : Page
    {

        ObservableCollection<Book> _list;
        public ProductsPage()
        {
            this.InitializeComponent();
        }

        private void LoadProduct(object sender, RoutedEventArgs e)
        {
            _list = new ObservableCollection<Book>{
                new Book() {ID=1,name="Lam Di" ,author="Nam Cao", price=100000, quantity=10000 }
            };

            dataGrid.ItemsSource = _list;
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //_list.Add(new Book() { ID = 2, name = "Chi Pheo", author = "Nam Cao", price = 100000, quantity = 10000 });
            var screen = new AddBookDialog();

            var newBook = new Book();
            screen.Handler += (Book value) =>
            {
                newBook = value;
            };

            screen.Activate();
            screen.Closed += (s, args) =>
            {
                _list.Add(newBook);
                _list.Add(new Book() { ID = 2, name = "Chi Pheo", author = "Nam Cao", price = 100000, quantity = 10000 });
            };
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            _list.RemoveAt(0);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            _list[0].name = "Cau Vang";
        }

    }
    
}
