using Entity;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddBookPage : Page
    {
        public delegate void AddNew(Book value);
        public event AddNew Handler;


        //List<BookCategory> _categories;
        public Book _newBook;

        ObservableCollection<BookCategory> _categories;
        public AddBookPage(ObservableCollection<BookCategory> cate)
        {
            this.InitializeComponent();

            this._categories = cate;
            LoadCategories();

            _newBook = new Book() { name = "" };

            bookForm.DataContext = _newBook;
        }

        public AddBookPage()
        {
            this.InitializeComponent();
        }

        private void LoadCategories()
        {
            //_categories = new List<BookCategory>() {
            //    new BookCategory() { Id=1, Name="Novel"},
            //    new BookCategory() { Id=2, Name="Manga"}
            //};

            categoriesComboBox.ItemsSource = _categories;
            categoriesComboBox.SelectedIndex = 0;
        }

        private void checkPrice(object sender, TextChangedEventArgs e)
        {

        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            var selectedCate = (BookCategory)categoriesComboBox.SelectedItem;
            _newBook.category_id = selectedCate.Id;
            Handler?.Invoke(_newBook);
        }
    }
}
