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
using ThreeLayerContract;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductsPage : Page
    {
        Dictionary<string, IBus> _bus = BusInstance._bus;

        ObservableCollection<Book> _list;
        ObservableCollection<BookCategory> _categories;
        //Dictionary<string, IBus> _bus;
        public ProductsPage()
        {
            //_bus = bus;
            this.InitializeComponent();
            newCateName.Text = "";

        }

        private void LoadProduct(object sender, RoutedEventArgs e)
        {
            //_list = new ObservableCollection<Book>{
            //    new Book() {ID=1,name="Lammm Di" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=2,name="Lao Hac" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=3,name="Cau Vang" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=1,name="Lammm Di" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=2,name="Lao Hac" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=3,name="Cau Vang" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=1,name="Lammm Di" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=2,name="Lao Hac" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=3,name="Cau Vang" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=1,name="Lammm Di" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=2,name="Lao Hac" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=3,name="Cau Vang" ,author="Nam Cao", price=100000, quantity=10000 },
            //    new Book() {ID=4,name="Chi Pheo" ,author="Nam Cao", price=100000, quantity=10000 }
            //};
            var configuration = new Dictionary<string, string>();
            _list = new ObservableCollection<Book>(_bus["Book"].Get(configuration));

            _categories = new ObservableCollection<BookCategory>
            {
                new BookCategory() { Id=1, Name="Truyen"},
                new BookCategory() { Id=2, Name="Tieu thuyet123215436576856534423432"},
                new BookCategory() { Id=0, Name="Tat ca"},
                new BookCategory() { Id=1, Name="Truyen"},
                new BookCategory() { Id=2, Name="Tieu thuyet123215436576856534423432"},
                new BookCategory() { Id=0, Name="Tat ca"},
                new BookCategory() { Id=1, Name="Truyen"},
                new BookCategory() { Id=2, Name="Tieu thuyet123215436576856534423432"},
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

            var newBook = new Book() { name = "", sku = "string" };
            screen.Handler += (Book value) =>
            {
                newBook = value;
                newBook.sku = "string";
                newBook.category_id = 1;
                newBook.total_sold = 0;
            };

            screen.Activate();
            screen.Closed += (s, args) =>
            {
                if (newBook.name == "")
                    return;


                bool isSuccess = _bus["Book"].Post(newBook, null);
                if (isSuccess)
                {
                    _list.Add(newBook);
                }
                //Dictionary<string, string> empty = null;
                //_bus["Book"].Post(newBook, empty);
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
                {
                    Book item = (Book)selectedItems[i];
                    if (deleteBook(item.ID))
                    {
                        _list.Remove(item);
                    }
                }
            }
        }

        private bool deleteBook(int id)
        {
            var configuration = new Dictionary<string, string> { { "id", id.ToString() } };
            return _bus["Book"].Delete(configuration);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            _list[0].name = "Cau Vang";
        }

        private void addBtnCate(object sender, RoutedEventArgs e)
        {
            if (addCateBox.Visibility == Visibility.Visible)
            {
                addCateBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                addCateBox.Visibility = Visibility.Visible;
            }
        }

        private void cancelCateBox(object sender, RoutedEventArgs e)
        {
            addCateBox.Visibility = Visibility.Collapsed;
            newCateName.Text = "";
        }

        private void addCateHandle(object sender, RoutedEventArgs e)
        {
            if (newCateName.Text != "")
            {
                var newCate = new BookCategory() { Id = 0, Name = newCateName.Text };
                _categories.Add(newCate);
                newCateName.Text = "";
            }
        }

        private void deleteCateHandle(object sender, RoutedEventArgs e)
        {
            _categories.Remove((BookCategory)listCategory.SelectedItem);
        }

        private void cancelEditCate(object sender, RoutedEventArgs e)
        {
            editCateBox.Visibility = Visibility.Collapsed;
        }

        private void updateToBind(object sender, SelectionChangedEventArgs e)
        {
            if (listCategory.SelectedItem != null)
            {
                BookCategory bookCategory = (BookCategory)listCategory.SelectedItem;
                newCateName_Edit.Text = bookCategory.Name;
            }
        }

        private void editCateHandle(object sender, RoutedEventArgs e)
        {

            if (listCategory.SelectedItem != null)
            {
                int index = listCategory.SelectedIndex;
                _categories[index].Name = newCateName_Edit.Text;
            }
            
        }

        private void editBtnCate(object sender, RoutedEventArgs e)
        {
            if (editCateBox.Visibility == Visibility.Visible)
            {
                editCateBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                editCateBox.Visibility = Visibility.Visible;
            }
        }
    }

}
