using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Entity;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditBookDialog : Window
    {
        public delegate void editBook(Book value, bool isEditted);
        public event editBook Handler;


        //List<BookCategory> _categories;
        public Book _newBook;

        List<BookCategory> _categories;

        public EditBookDialog(ObservableCollection<BookCategory> cate, Book book)
        {
            this.InitializeComponent();
            this._categories = new List<BookCategory>(cate);
            _newBook = book;
            LoadCategories();


            bookForm.DataContext = _newBook;
        }

        private void LoadCategories()
        {
            categoriesComboBox.ItemsSource = _categories;
            var index = _categories.FindIndex(x => x.Id == _newBook.category_id);
            categoriesComboBox.SelectedIndex = index;
            
        }

        private void EditButton(object sender, RoutedEventArgs e)
        {
            var selectedCate = (BookCategory)categoriesComboBox.SelectedItem;
            _newBook.category_id = selectedCate.Id;
            Handler?.Invoke(_newBook, true);
            this.Close();
        }
    }
}
