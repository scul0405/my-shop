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
using Windows.UI.Popups;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductsPage : Page
    {

        ObservableCollection<Book> _list;
        ObservableCollection<BookCategory> _categories;
        public ProductsPage()
        {
            this.InitializeComponent();
        }

        private void LoadProduct(object sender, RoutedEventArgs e)
        {
            _list = new ObservableCollection<Book>{
                new Book() {ID=1,name="Lammm Di" ,author="Nam Cao", price=100000, quantity=10000 },
                new Book() {ID=2,name="Lao Hac" ,author="Nam Cao", price=100000, quantity=10000 },
                new Book() {ID=3,name="Cau Vang" ,author="Nam Cao", price=100000, quantity=10000 },
                new Book() {ID=4,name="Chi Pheo" ,author="Nam Cao", price=100000, quantity=10000 }
            };

            _categories = new ObservableCollection<BookCategory>
            {
                new BookCategory() { Id=0, Name="Tat ca"},
                new BookCategory() { Id=1, Name="Truyen"},
                new BookCategory() { Id=2, Name="Tieu thuyet123215436576856534423432"},
                new BookCategory() { Id=3, Name="Sach"}
            }; 

            dataGrid.ItemsSource = _list;
            //categoriesComboBox.ItemsSource = _categories;
            //categoriesComboBox.SelectedIndex = 0;
            listCategory.ItemsSource = _categories;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //_list.Add(new Book() { ID = 2, name = "Chi Pheo", author = "Nam Cao", price = 100000, quantity = 10000 });
            var screen = new AddBookDialog();

            var newBook = new Book() { name=""};
            screen.Handler += (Book value) =>
            {
                newBook = value;
            };

            screen.Activate();
            screen.Closed += (s, args) =>
            {
                if (newBook.name == "")
                    return;
                _list.Add(newBook);
                //_list.Add(new Book() { ID = 2, name = "Chi Pheo", author = "Nam Cao", price = 100000, quantity = 10000 });
            };
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //_list.Remove((Book)dataGrid.SelectedItems);
            var selectedItems = dataGrid.SelectedItems;
            if (dataGrid.SelectedItems.Count > 0)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    _list.Remove((Book)selectedItems[i]);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            _list[0].name = "Cau Vang";
        }

    }
    
}
