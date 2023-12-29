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
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    public sealed partial class CreateOrderPage : Page
    {
        private List<String> comboboxItem = new List<String> { "Book 1", "Book 2", "Book 3" };
        private ObservableCollection<OrderedBook> allBooks = new ObservableCollection<OrderedBook>();
        private ObservableCollection<OrderedBookViewModel> orderedBooks = new ObservableCollection<OrderedBookViewModel>();

        public ObservableCollection<OrderedBook> AllBooks
        {
            get { return allBooks; }
        }

        public CreateOrderPage()
        {
            this.InitializeComponent();
            BooksGrid.ItemsSource = orderedBooks;

            // Adding some initial books for testing
            allBooks.Add(new OrderedBook("Book 1"));
            allBooks.Add(new OrderedBook("Book 2"));
            allBooks.Add(new OrderedBook("Book 3"));
            ComboboxColumn.ItemsSource = comboboxItem;

            // Adding some initial rows for testing
            AddBookRow();
            AddBookRow();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            // Add a new row with a ComboBox to select books
            AddBookRow();
        }

        private void RemoveBookButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the button that was clicked
            var removeButton = sender as Button;

            // Get the corresponding item in the DataContext
            var item = removeButton?.DataContext as OrderedBookViewModel;

            // Remove the item from the ObservableCollection
            if (item != null)
            {
                orderedBooks.Remove(item);
            }
        }

        private void AddBookRow()
        {
            // Add a new row with a ComboBox to select books
            orderedBooks.Add(new OrderedBookViewModel(allBooks));
        }
    }

    // Model class for an ordered book
    public class OrderedBook
    {
        public string Book { get; set; }

        public OrderedBook(string book)
        {
            this.Book = book;
        }
    }

    // ViewModel class for an ordered book with additional properties
    public class OrderedBookViewModel : INotifyPropertyChanged
    {
        private string selectedBook;
        private int quantity;

        public ObservableCollection<OrderedBook> AllBooks { get; set; }

        public string SelectedBook
        {
            get { return selectedBook; }
            set
            {
                if (selectedBook != value)
                {
                    selectedBook = value;
                    OnPropertyChanged(nameof(SelectedBook));
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        public OrderedBookViewModel(ObservableCollection<OrderedBook> allBooks)
        {
            this.AllBooks = allBooks;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}