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
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage;
using Telerik.UI.Xaml.Controls;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductsPage : Microsoft.UI.Xaml.Controls.Page
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
            var configuration = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            try
            {
                var tempList = new List<Book>(_bus["Book"].Get(configuration)).Where(book => book.status);

                //_list = new ObservableCollection<Book>(_bus["Book"].Get(configuration));
                _list = new ObservableCollection<Book>(tempList);
            }
            catch
            {
                _list = new ObservableCollection<Book>();
            }
            dataGrid.ItemsSource = _list;

            try
            {
                _categories = new ObservableCollection<BookCategory>(_bus["BookCategory"].Get(configuration));

            }
            catch
            {
                _categories = new ObservableCollection<BookCategory>();
            }
            listCategory.ItemsSource = _categories;


        }

        private async void ShowSuccessMessage()
        {

            var successDialog = new ContentDialog
            {
                Title = "Success",
                Content = "Action successfully completed",
                CloseButtonText = "OK"
            };

            if (successDialog.XamlRoot != null)
            {
                successDialog.XamlRoot = null;
            }

            successDialog.XamlRoot = this.Content.XamlRoot;
            await successDialog.ShowAsync();
        }

        private async void ShowFailMessage()
        {

            var failDialog = new ContentDialog
            {
                Title = "Failed",
                Content = "Some errors occured",
                CloseButtonText = "OK"
            };

            if (failDialog.XamlRoot != null)
            {
                failDialog.XamlRoot = null;
            }

            failDialog.XamlRoot = this.Content.XamlRoot;
            await failDialog.ShowAsync();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(AddBookPage));
            //_list.Add(new Book() { ID = 2, name = "Chi Pheo", author = "Nam Cao", price = 100000, quantity = 10000 });
            var screen = new AddBookDialog(_categories);

            var newBook = new Book() { name = "", desc = "" };
            screen.Handler += (Book value) =>
            {
                newBook = value;
                //newBook.total_sold = 0;
            };

            screen.Activate();
            screen.Closed += (s, args) =>
            {
                if (newBook.name == "")
                    return;


                bool isSuccess = _bus["Book"].Post(newBook, null);
                if (isSuccess)
                {
                    ShowSuccessMessage();
                    var config = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
                    var tempList = new List<Book>(_bus["Book"].Get(config)).Where(book => book.status);
                    _list = new ObservableCollection<Book>(tempList);
                    dataGrid.ItemsSource = _list;
                    //_list.Add(newBook);
                }
                else
                {
                    ShowFailMessage();
                }
            };
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //_list.Remove((Book)dataGrid.SelectedItems);
            var selectedItems = dataGrid.SelectedItems;
            var isSucess = true;
            if (dataGrid.SelectedItems.Count > 0)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    Book item = (Book)selectedItems[i];
                    if (deleteBook(item.ID, item))
                    {
                        _list.Remove(item);
                    }
                    else
                    {
                        isSucess = false;
                    }
                }
            }
            if (!isSucess)
            {
                ShowFailMessage();
            }
            else
            {
                ShowSuccessMessage();
            }
        }

        private bool deleteBook(int id, Book book)
        {
            var configuration = new Dictionary<string, string> { { "id", id.ToString() } };
            book.status = false;
            return _bus["Book"].Patch(book, configuration);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //_list[0].name = "Cau Vang1234567890qwertyuiopadfghjklzxcvbnm,1234567890008765432123456789098765432123456789";
            if (dataGrid.SelectedItems.Count != 1)
            {
                ShowFailMessage();
                return;
            }
            var oldBook = (Book)dataGrid.SelectedItem;
            var newBook = new Book();
            newBook.ID = oldBook.ID;
            newBook.name = oldBook.name;
            newBook.category_id = oldBook.category_id;
            newBook.author = oldBook.author;
            newBook.price = oldBook.price;
            newBook.quantity = oldBook.quantity;
            newBook.status = oldBook.status;
            var index = _list.IndexOf(oldBook);
            var screen = new EditBookDialog(_categories, newBook);

            bool _isEditted = false;

            screen.Handler += (Book value, bool isEditted) =>
            {
                newBook = value;
                _isEditted = isEditted;
            };

            screen.Activate();
            screen.Closed += (s, args) =>
            {
                if (_isEditted)
                {
                    var res = _bus["Book"].Patch(newBook, null);
                    if (res)
                    {
                        ShowSuccessMessage();
                        _list[index] = newBook;
                    }
                    else
                    {
                        ShowFailMessage();
                        _list[index] = oldBook;
                    }
                    return;
                }
                _list[index] = oldBook;
            };
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
                var newCate = new BookCategory() { Name = newCateName.Text };
                if (_bus["BookCategory"].Post(newCate, null))
                {
                    ShowSuccessMessage();
                    var config = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
                    _categories = new ObservableCollection<BookCategory>(_bus["BookCategory"].Get(config));
                    listCategory.ItemsSource = _categories;
                    //_categories.Add(newCate);
                    newCateName.Text = "";
                }
                else
                {
                    ShowFailMessage();
                }
            }
        }

        private void deleteCateHandle(object sender, RoutedEventArgs e)
        {

            if (listCategory.SelectedItems.Count == 1)
            {
                var cate = (BookCategory)listCategory.SelectedItem;
                var config = new Dictionary<string, string> { { "id", $"{cate.Id}" } };
                if (_bus["BookCategory"].Delete(config))
                {
                    ShowSuccessMessage();
                    _categories.Remove((BookCategory)listCategory.SelectedItem);
                }
                else
                {
                    ShowFailMessage();
                }
            }
            else
            {
                ShowFailMessage();
            }

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
                var cate = (BookCategory)listCategory.SelectedItem;
                cate.Name = newCateName_Edit.Text;
                _bus["BookCategory"].Patch(cate, null);
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

        private void filterByCate(object sender, RoutedEventArgs e)
        {
            if (listCategory.SelectedItem == null)
            {
                ShowFailMessage();
                return;
            }

            var cate = ((BookCategory)listCategory.SelectedItem).Id;
            dataGrid.ItemsSource = _list.Where(book => book.category_id == cate);
        }

        private void resetFilter(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = _list;
        }

        private async void importCategory(object sender, RoutedEventArgs e)
        {

            var window = new Window();
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            var picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".xlsx");
            List<Book> listBookImport = new List<Book>();
            List<string> listCategoryName = new List<string>();
            List<string> listCategoryImport = new List<string>();

            WinRT.Interop.InitializeWithWindow.Initialize(picker, hwnd);
            StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                using (Stream stream = (await file.OpenReadAsync()).AsStreamForRead())
                using (SpreadsheetDocument document = SpreadsheetDocument.Open(stream, false))
                {
                    filePicked.DataContext = file.Name;

                    WorkbookPart workbookPart = document.WorkbookPart;
                    //Import Category
                    Sheet sheetCate = workbookPart.Workbook.Descendants<Sheet>().ElementAt(0);

                    if (sheetCate == null)
                    {
                        ShowFailMessage();
                        return;
                    }

                    WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(sheetCate.Id);
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                    foreach (Row row in sheetData.Elements<Row>())
                    {
                        foreach (Cell cell in row.Elements<Cell>())
                        {
                            string cellValue = GetCellCategory(cell, workbookPart);
                            if (_categories.Any(cate => cate.Name == cellValue)) continue;
                            //testRead.Add(cellValue);
                            BookCategory newCate = new BookCategory() { Name = cellValue };
                            listCategoryImport.Add(cellValue);
                            // Process each cell individually (in this example, just print the value)
                            Console.WriteLine(cellValue);
                        }
                    }

                    //Import Book
                    Sheet sheetBook = workbookPart.Workbook.Descendants<Sheet>().ElementAtOrDefault(1);

                    if (sheetBook == null)
                    {
                        ShowFailMessage();
                        return;
                    }

                    WorksheetPart worksheetPartBook = (WorksheetPart)workbookPart.GetPartById(sheetBook.Id);
                    SheetData sheetDataBook = worksheetPartBook.Worksheet.Elements<SheetData>().First();

                    foreach (Row row in sheetDataBook.Elements<Row>())
                    {
                        string name = GetCellValueInRow(row, "A", workbookPart);
                        if (_list.Any(book => book.name == name)) continue;
                        string author = GetCellValueInRow(row, "B", workbookPart);
                        string category_name = GetCellValueInRow(row, "C", workbookPart);
                        int totalSold = GetCellValueInRowAsInt(row, "D", workbookPart);
                        int price = GetCellValueInRowAsInt(row, "E", workbookPart);
                        int quantity = GetCellValueInRowAsInt(row, "F", workbookPart);
                        Book newBook = new Book() { name = name, author = author, total_sold = totalSold, price = price, quantity = quantity, status = true };
                        //testReadBook_string.Add(name);
                        //testReadBook_int.Add(intValue);
                        listCategoryName.Add(category_name);
                        listBookImport.Add(newBook);
                    }
                    //TODO call BE to pass listCategoryImport, listBookImport, listCategoryName
                    var jsonData = new
                    {
                        book_categories = listCategoryName,
                        books = listBookImport,
                        categories = listCategoryImport
                    };
                    
                    var thanhcong = _bus["Migrate"].Post(jsonData, null);
                    if (thanhcong)
                    {
                        ShowSuccessMessage();
                    }
                    else
                    {
                        ShowFailMessage();
                    }

                    //GEt data again to update new data
                    var config = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
                    _categories = new ObservableCollection<BookCategory>(_bus["BookCategory"].Get(config));
                    listCategory.ItemsSource = _categories;

                    _list = new ObservableCollection<Book>(_bus["Book"].Get(config));
                    dataGrid.ItemsSource = _list;

                }

            }
            else
            {
                ShowFailMessage();
            }

            window.Close();
        }

        static string GetCellCategory(Cell cell, WorkbookPart workbookPart)
        {
            if (cell.DataType != null && cell.DataType == CellValues.SharedString)
            {
                int sharedStringIndex = int.Parse(cell.InnerText);
                SharedStringTablePart sharedStringPart = workbookPart.SharedStringTablePart;
                return sharedStringPart.SharedStringTable.Elements<SharedStringItem>().ElementAt(sharedStringIndex).InnerText;
            }
            else
            {
                return cell.InnerText;
            }
        }

        static string GetCellBook(Cell cell, WorkbookPart workbookPart)
        {
            if (cell.DataType != null && cell.DataType == CellValues.SharedString)
            {
                int sharedStringIndex = int.Parse(cell.InnerText);
                SharedStringTablePart sharedStringPart = workbookPart.SharedStringTablePart;
                return sharedStringPart.SharedStringTable.Elements<SharedStringItem>().ElementAt(sharedStringIndex).InnerText;
            }
            else
            {
                return cell.InnerText;
            }
        }

        static string GetCellValueInRow(Row row, string columnName, WorkbookPart workbookPart)
        {
            Cell cell = row.Elements<Cell>().FirstOrDefault(c => c.CellReference == columnName + row.RowIndex);
            return cell != null ? GetCellValue(cell, workbookPart) : null;
        }

        static int GetCellValueInRowAsInt(Row row, string columnName, WorkbookPart workbookPart)
        {
            Cell cell = row.Elements<Cell>().FirstOrDefault(c => c.CellReference == columnName + row.RowIndex);
            return cell != null ? int.Parse(GetCellValue(cell, workbookPart)) : 0; // Assumes a default value of 0 if the cell is empty or not a valid integer.
        }

        static string GetCellValue(Cell cell, WorkbookPart workbookPart)
        {
            if (cell.DataType != null && cell.DataType == CellValues.SharedString)
            {
                int sharedStringIndex = int.Parse(cell.InnerText);
                SharedStringTablePart sharedStringPart = workbookPart.SharedStringTablePart;
                return sharedStringPart.SharedStringTable.Elements<SharedStringItem>().ElementAt(sharedStringIndex).InnerText;
            }
            else
            {
                return cell.InnerText;
            }
        }
    }

}
