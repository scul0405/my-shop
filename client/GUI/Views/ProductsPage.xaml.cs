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
                new Book() {ID="001", Title="Kafka ben bo bien"}
            };

            dataGrid.ItemsSource = _list;
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _list.Add(new Book() { ID = "002", Title = "Lao Hac" });
            //books.Rows.Add("002", "LaoHac");    
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            _list.RemoveAt(0);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            _list[0].Title = "Cau Vang";
        }

    }
    class Book : INotifyPropertyChanged
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
