using CommunityToolkit.Labs.WinUI;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Entity;
using GUI.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ThreeLayerContract;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT.Interop;
using static GUI.Views.SettingPage;


// TODO: Check tất cả điều kiện để bắt sự kiện thông báo cho người dùng.
// File excel có định dạng như sau:
// Dòng 1: Số lượng quyển sách cần thêm vào
// Dòng 2: Tên các cột (chỗ này để cho vui thôi, nhưng logic code đang lấy từ dòng thứ 3)
// Dòng 3 trở đi: Dữ liệu của các quyển sách
// Nên đưa logic qua viewModel
// LOGIC
// Hai sách gọi là giống nhau khi giống đồng thời tên, thể loại và tác giả
namespace GUI.Views
{
    public sealed partial class SettingPage : Microsoft.UI.Xaml.Controls.Page
    {
        public SettingViewModel ViewModel { get; } = new SettingViewModel();

        bool isImportSuccess = true;
        List<ImportBook> validImportBooks;
        List<ImportBook> ImportBooksWithAvaiableCategory;

        int theNumberOfBookCanFound = 0;
        int theNumberOfBookCanImport = 0;
        int theNumberOfBookDuplicate = 0;

        string msg = "";

        public SettingPage()
        {
            this.InitializeComponent();
        }

        public class ImportBook
        {
            public int BookID { get; set; }
            public int CategoryID { get; set; }
            public string Desc { get; set; }
            public string Name { get; set; }
            public string Author { get; set; }
            public string CategoryName { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public int TotalSold { get; set; }

            public string toString()
            {
                return $"{CategoryID}, {CategoryName}, {Author}, {Desc}, {Name}, {Price}, {Quantity}, {TotalSold}";
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                ImportBook other = (ImportBook)obj;
                return this.Author.ToLower().Trim().Equals(other.Author.ToLower().Trim())
                    && this.Name.ToLower().Trim().Equals(other.Name.ToLower().Trim())
                    && this.CategoryName.ToLower().Trim().Equals(other.CategoryName.ToLower().Trim());
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Author, Name, CategoryName);
            }
        }

        private async void ImportExcelButton_Click(object sender, RoutedEventArgs e)
        {
            isImportSuccess = true;
            var window = new Window();
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(window);

            var picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".xlsx");

            // InitializeWithWindow to set the window handle
            WinRT.Interop.InitializeWithWindow.Initialize(picker, hwnd);

            StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                var listCategoryName = new List<string>();
                var importBooks = new List<ImportBook>();

                try
                {
                    using (var stream = await file.OpenReadAsync())
                    using (var document = SpreadsheetDocument.Open(stream.AsStream(), false))
                    {
                        WorkbookPart workbookPart = document.WorkbookPart;
                        Sheet sheet = workbookPart.Workbook.Descendants<Sheet>().FirstOrDefault();
                        WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(sheet.Id);
                        SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                        int rowsToImport = 0;
                        int currentRow = 0;

                        // Import data from Excel
                        foreach (Row row in sheetData.Elements<Row>())
                        {
                            var cellValues = new List<string>();
                            ImportBook importBook = new ImportBook();

                            foreach (Cell cell in row.Elements<Cell>())
                            {
                                string cellValue = GetCellValue(cell, workbookPart);
                                Debug.WriteLine("CellValue in " + currentRow + ": " + cellValue);

                                if (currentRow == 0)  // Dòng 1 chứa số lượng quyển sách cần thêm vào
                                {
                                    rowsToImport = int.Parse(cellValue);
                                    theNumberOfBookCanFound = rowsToImport;
                                    theNumberOfBookCanImport = rowsToImport;
                                    break;
                                }

                                if (currentRow == 1)  // Dòng 2 chứa tên các cột
                                {
                                    break;
                                }

                                // Xác định cột và gán giá trị cho thuộc tính tương ứng của importBook
                                Debug.WriteLine("Current col: " + GetColumnName(cell.CellReference.Value));

                                string columnName = GetColumnName(cell.CellReference.Value);
                                char firstChar = columnName.ToUpper()[0];

                                if (firstChar >= 'A' && firstChar <= 'G')
                                {

                                    switch (firstChar)
                                    {
                                        case 'A':
                                            importBook.CategoryName = cellValue;
                                            Debug.WriteLine("Case book_categories: " + cellValue + "/" + importBook.CategoryName);
                                            break;
                                        case 'B':
                                            importBook.Author = cellValue;
                                            Debug.WriteLine("Case author: " + cellValue + "/" + importBook.Author);
                                            break;
                                        case 'C':
                                            importBook.Desc = cellValue;
                                            Debug.WriteLine("Case desc: " + cellValue + "/" + importBook.Desc);
                                            break;
                                        case 'D':
                                            importBook.Name = cellValue;
                                            Debug.WriteLine("Case name: " + cellValue + "/" + importBook.Name);
                                            break;
                                        case 'E':
                                            importBook.Price = int.Parse(cellValue);
                                            Debug.WriteLine("Case price: " + cellValue + "/" + importBook.Price);
                                            break;
                                        case 'F':
                                            importBook.Quantity = int.Parse(cellValue);
                                            Debug.WriteLine("Case quantity: " + cellValue + "/" + importBook.Quantity);
                                            break;
                                        case 'G':
                                            importBook.TotalSold = int.Parse(cellValue);
                                            Debug.WriteLine("Case total_sold: " + cellValue + "/" + importBook.TotalSold);
                                            break;
                                        default:
                                            break;
                                    }

                                }

                                cellValues.Add(cellValue);
                            }
                            Debug.WriteLine("importBook: " + importBook.toString());

                            // Bắt đầu lấy dữ liệu từ dòng tiếp theo sau tiêu đề
                            if (currentRow > 1)
                            {
                                // Add cell values to the list
                                importBooks.Add(importBook);

                                // Break the loop when reaching the specified number of rows to import
                                if (--rowsToImport == 0)
                                {
                                    break;
                                }
                            }

                            currentRow++;
                        }
                    }

                }
                catch
                {
                    isImportSuccess = false;
                }

                // Nếu xảy ra exception trong quá trình parser hay một cái con khỉ gì đó
                // thì out
                if (isImportSuccess)
                {
                    Debug.WriteLine("-----------------------------------------------------");
                    // check data
                    List<ImportBook> allAvaiableImportBooks = AllAvaiableImportBook();
                    List<ImportBook> tempImportBooks = new List<ImportBook>();

                    if (allAvaiableImportBooks != null)
                    {
                        // List này sẽ chứa toàn bộ các phần tử không trùng với dữ liệu hiện có trên database
                        List<ImportBook> canUpdate = new List<ImportBook>();

                        validImportBooks = new List<ImportBook>();
                        ImportBooksWithAvaiableCategory = new List<ImportBook>();


                        // Case 0: List ra các phần tử bị trùng với dữ liệu hiện có trên database
                        // chứa phần tử trùng giữa tempImportBooks và allAvaiableImportBooks
                        var commonImportBooks = importBooks
                                                .Where(importBook => allAvaiableImportBooks
                                                .Any(avaiableImportBook => avaiableImportBook
                                                .Equals(importBook))).ToList();


                        // Case 1: Tồn tại phần tử trùng trong list
                        // remove các phần tử trùng trong list 
                        var distinctImportBooks = importBooks.Distinct(new ImportBookComparer()).ToList();
                        if (distinctImportBooks.Count == importBooks.Count)
                        {
                            Debug.WriteLine("distinctImportBooks.Count == importBooks.Count");
                        }
                        else
                        {
                            theNumberOfBookDuplicate = importBooks.Count - distinctImportBooks.Count;
                        }

                        // Case 3: List ra các phần tử bị trùng với dữ liệu hiện có trên database
                        // Có kèm theo dòng trùng, index trong importBooks bị trùng để xử lý.
                        var commonImportBooksWithIndex = importBooks
                            .Select((importBook, index) => new { ImportBook = importBook, Index = index })
                            .Where(item => allAvaiableImportBooks.Any(avaiableImportBook => avaiableImportBook.Equals(item.ImportBook)))
                            .Distinct().ToList();

                        Debug.WriteLine("theNumberOfBookCanImport after delete database avaiable " + theNumberOfBookCanImport);

                        // Case 4: List ra các phần tử không trùng với dữ liệu hiện có trên database
                        // Có kèm theo dòng không trùng, index trong importBooks không trùng để xử lý.
                        var differentImportBooksWithIndex = importBooks
                            .Select((importBook, index) => new { ImportBook = importBook, Index = index })
                            .Except(commonImportBooksWithIndex)
                            .ToList();


                        // Case 5: Sử dụng list ở Case 4, lấy ra những quyển sách đã tồn tại Category trên database
                        // Có kèm theo số dòng, index trong importBooks để xử lý
                        // Xử lý: Thêm vào database lần lượt những quyển sách có cùng Category với quyển sách đã tồn tại
                        var matchedImportBooks = differentImportBooksWithIndex
                            .Join(
                                allAvaiableImportBooks,
                                diffItem => diffItem.ImportBook.CategoryName.ToLower().Trim(),
                                avaiableItem => avaiableItem.CategoryName.ToLower().Trim(),
                                (diffItem, avaiableItem) => new
                                {
                                    ImportBook = diffItem.ImportBook,
                                    IndexInImportBooks = diffItem.Index,
                                    DuplicateCategoryId = avaiableItem.CategoryID
                                })
                            .Distinct().ToList();

                        // Case 6: Truyền list là những quyển sách chưa tồn tại trên database 
                        // nghĩa là những quyển sách có Category không tồn tại trên database

                        var uniqueDifferentImportBooks = differentImportBooksWithIndex
                            .Where(diffItem => matchedImportBooks.All(avaiableItem => !diffItem.ImportBook.Equals(avaiableItem.ImportBook)))
                            .Select(item => (ImportBook)item.ImportBook)
                            .Distinct().ToList();

                        foreach (var book in uniqueDifferentImportBooks)
                        {
                            Debug.WriteLine("[uniqueDifferentImportBooks]: "
                                + book.toString());
                            tempImportBooks.Add(book);
                        }
                        tempImportBooks = tempImportBooks.Distinct(new ImportBookComparer()).ToList();

                        // Duyệt qua để gán ImportBooksWithAvaiableCategory
                        foreach (var book in matchedImportBooks)
                        {
                            ImportBook import = new ImportBook();
                            import = book.ImportBook;
                            import.CategoryID = book.DuplicateCategoryId;
                            Debug.WriteLine("[matchedImportBooks]: "
                                + book.ImportBook.toString()
                                + ", index: " + book.IndexInImportBooks
                                + ", line: " + (book.IndexInImportBooks + 3)
                                + ", idCateGory: " + book.DuplicateCategoryId);
                            ImportBooksWithAvaiableCategory.Add(import);
                        }
                        ImportBooksWithAvaiableCategory.Distinct(new ImportBookComparer()).ToList();


                        foreach (var book in commonImportBooksWithIndex)
                        {
                            Debug.WriteLine("[commonImportBooksWithIndex]: "
                                + book.ImportBook.toString()
                                + ", index: " + book.Index
                                + ", line: " + (book.Index + 3));
                        }

                        foreach (var book in differentImportBooksWithIndex)
                        {
                            Debug.WriteLine("[differentImportBooksWithIndex]: "
                                + book.ImportBook.toString()
                                + ", index: " + book.Index
                                + ", line: " + (book.Index + 3));
                            canUpdate.Add(book.ImportBook);
                        }
                        canUpdate = canUpdate.Distinct(new ImportBookComparer()).ToList();
                        theNumberOfBookCanImport = canUpdate.Count;

                        foreach (ImportBook book in importBooks)
                        {
                            Debug.WriteLine("[importBooks]: " + book.CategoryName + " " + book.Author + " " + book.Desc + " " + book.Name + " " + book.Price + " " + book.Quantity + " " + book.TotalSold);
                        }

                        foreach (ImportBook book in commonImportBooks)
                        {
                            Debug.WriteLine("[commonImportBooks]: " + book.CategoryName + " " + book.Author + " " + book.Desc + " " + book.Name + " " + book.Price + " " + book.Quantity + " " + book.TotalSold);
                        }

                        foreach (ImportBook book in distinctImportBooks)
                        {
                            Debug.WriteLine("[distinctImportBooks]: " + book.CategoryName + " " + book.Author + " " + book.Desc + " " + book.Name + " " + book.Price + " " + book.Quantity + " " + book.TotalSold);
                        }

                        List<BookCategory> bookCategories = AllAvaiableCategory();

                        foreach (ImportBook book in tempImportBooks)
                        {
                            // Kiểm tra xem có category nào trong bookCategories có tên trùng với CategoryName của book không
                            var matchingCategory = bookCategories.FirstOrDefault(category => book.CategoryName.ToLower().Trim()
                                                                                                .Equals(category.Name.ToLower().Trim()));

                            if (matchingCategory != null)
                            {
                                // Nếu có, gán CategoryID và thêm vào ImportBooksWithAvaiableCategory
                                book.CategoryID = matchingCategory.Id;
                                ImportBooksWithAvaiableCategory.Add(book);
                            }
                            else
                            {
                                // Nếu không có, thêm vào validImportBooks
                                validImportBooks.Add(book);
                            }
                        }

                        foreach (ImportBook book in canUpdate)
                        {
                            Debug.WriteLine("[canUpdate]: " + book.toString());
                        }

                        foreach (ImportBook book in validImportBooks)
                        {
                            listCategoryName.Add(book.CategoryName);
                            Debug.WriteLine("[validImportBooks]: " + book.toString());
                        }

                        foreach (ImportBook book in ImportBooksWithAvaiableCategory)
                        {
                            Debug.WriteLine("[ImportBooksWithAvaiableCategory]: " + book.toString());
                        }

                    }
                    WriteToJsonFile("out.json", listCategoryName, validImportBooks);
                }


                if (isImportSuccess)
                {
                    ImportWithID(ImportBooksWithAvaiableCategory);
                    msg = "Import " + theNumberOfBookCanImport + "/" + theNumberOfBookCanFound + " books successfully.";
                    ShowMessage(msg);
                }
                else
                {
                    ShowMessage("Cannot import from this file.");
                }

                Debug.WriteLine("Import " + theNumberOfBookCanImport + "/" + theNumberOfBookCanFound);

            }
        }

        private void ImportWithID(List<ImportBook> importBooks)
        {
            Dictionary<string, IBus> _bus = BusInstance._bus;
            foreach (var item in importBooks)
            {
                var book = new Book();
                book = ImportBookToBookConverter(item);
                try
                {
                    if (_bus["Book"].Post(book, null))
                    {
                        Debug.WriteLine("ImportWithID is OK");
                    }
                    else
                    {
                        theNumberOfBookCanImport--;
                        Debug.WriteLine("ImportWithID is not OK");
                    }
                }
                catch
                {
                    //eat
                }
            }
        }

        private void WriteToJsonFile(string fileName, List<string> listCategoryName, List<ImportBook> importBooks)
        {
            var temp = new List<string>(listCategoryName);
            var uniqueCategoryName = temp.Distinct().ToList();

            var jsonData = new
            {
                book_categories = listCategoryName,
                books = importBooks.Select(book => new
                {
                    author = book.Author,
                    desc = book.Desc,
                    name = book.Name,
                    price = book.Price,
                    quantity = book.Quantity,
                    total_sold = book.TotalSold
                }).ToList(),
                categories = uniqueCategoryName
            };

            string jsonContent = JsonSerializer.Serialize(jsonData, new JsonSerializerOptions { WriteIndented = true });
            Debug.WriteLine(jsonContent);


            // Chỗ này cần tách ra hàm riêng để xử lý, bỏ luôn hàm ghi file ra json vì đéo để làm gì cả
            Dictionary<string, IBus> _bus = BusInstance._bus;
            var dynamic = new { };
            try
            {
                isImportSuccess = _bus["Migrate"].Post(jsonData, null);
            }
            catch (Exception e)
            {
                msg = "Cannot import with POST method.";
                Debug.WriteLine("Error in import: " + e.Message);
            }

            // Sử dụng Encoding.UTF8 khi ghi vào file
            WriteToFile(fileName, jsonContent, Encoding.UTF8);
        }

        private static async void WriteToFile(string fileName, string content, Encoding encoding)
        {
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile outputFile = await folder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);

            // Sử dụng encoding khi mở stream để ghi nội dung vào file
            using (StreamWriter writer = new StreamWriter(await outputFile.OpenStreamForWriteAsync(), encoding))
            {
                await writer.WriteLineAsync(content);
            }
            Debug.WriteLine($"File written to: {outputFile.Path}");
        }



        private static string GetCellValue(Cell cell, WorkbookPart workbookPart)
        {
            SharedStringTablePart stringTablePart = workbookPart.SharedStringTablePart;
            string value = cell.InnerText;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[int.Parse(value)].InnerText;
            }

            return value;
        }

        private static string GetColumnName(string cellReference)
        {
            return cellReference.Substring(0, cellReference.Length - 1);
        }

        private List<BookCategory> AllAvaiableCategory()
        {
            Dictionary<string, IBus> _bus = BusInstance._bus;
            var configuration = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            try
            {
                var tempList = new List<BookCategory>(_bus["BookCategory"].Get(configuration));
                Debug.WriteLine("AllAvaiableCategory is OK");
                if (tempList == null)
                {
                    Debug.WriteLine("tempList is null");
                }
                return tempList;
            }
            catch
            {
                Debug.WriteLine("Error in AllAvaiableCategory");
                return null;
            }
        }

        private List<Book> AllAvaiableBook()
        {
            Dictionary<string, IBus> _bus = BusInstance._bus;
            var configuration = new Dictionary<string, string> { { "size", int.MaxValue.ToString() } };
            try
            {
                var tempList = new List<Book>(_bus["Book"].Get(configuration));
                Debug.WriteLine("AllAvaiableBook is OK");
                if (tempList == null)
                {
                    Debug.WriteLine("tempList is null");
                }
                return tempList;
            }
            catch
            {
                Debug.WriteLine("Error in AllAvaiableBook");
                return null;
            }
        }

        private List<ImportBook> AllAvaiableImportBook()
        {
            List<BookCategory> categoriesList = AllAvaiableCategory();
            List<Book> booksList = AllAvaiableBook();
            if (categoriesList != null && booksList != null)
            {
                List<ImportBook> importBooks = new List<ImportBook>();
                foreach (Book book in booksList)
                {
                    ImportBook importBook = new ImportBook();
                    importBook.BookID = book.ID;
                    importBook.CategoryID = book.category_id;
                    importBook.Desc = book.desc;
                    importBook.Name = book.name;
                    importBook.Author = book.author;
                    importBook.CategoryName = categoriesList.Find(category => category.Id == book.category_id).Name;
                    importBook.Price = book.price;
                    importBook.Quantity = book.quantity;
                    importBook.TotalSold = book.total_sold;
                    importBooks.Add(importBook);
                }
                Debug.WriteLine("AllAvaiableImportBook is OK");
                if (importBooks == null)
                {
                    Debug.WriteLine("importBooks is null");
                }
                return importBooks;
            }
            else
            {
                Debug.WriteLine("Error in AllAvaiableImportBook");
                return null;
            }
        }

        private Book ImportBookToBookConverter(ImportBook importBook)
        {
            Book book = new Book();
            book.ID = importBook.BookID;
            book.category_id = importBook.CategoryID;
            book.desc = importBook.Desc;
            book.name = importBook.Name;
            book.author = importBook.Author;
            book.price = importBook.Price;
            book.quantity = importBook.Quantity;
            book.total_sold = importBook.TotalSold;
            return book;
        }

        private bool AddBookWithTheSameCategory(ImportBook importBook)
        {
            bool isSuccess = false;
            Dictionary<string, IBus> _bus = BusInstance._bus;
            try
            {
                Book newBook = ImportBookToBookConverter(importBook);
                isSuccess = _bus["Book"].Post(newBook, null);
            }
            catch
            {
                //eat
            }
            return isSuccess;
        }

        private void IsEnabledToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private async void ShowMessage(string msg)
        {
            // Hiển thị thông báo đăng nhập thành công
            var successDialog = new ContentDialog
            {
                Title = "Import data from file.",
                Content = msg,
                CloseButtonText = "Cancel"
            };

            if (successDialog.XamlRoot != null)
            {
                successDialog.XamlRoot = null;
            }

            successDialog.XamlRoot = this.Content.XamlRoot;

            await successDialog.ShowAsync();
        }
    }

    public class ImportBookComparer : IEqualityComparer<ImportBook>
    {
        public bool Equals(ImportBook x, ImportBook y)
        {
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] ImportBook obj)
        {
            return obj.GetHashCode();
        }
    }
}
