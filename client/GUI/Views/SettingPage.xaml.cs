using CommunityToolkit.Labs.WinUI;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
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
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT.Interop;

namespace GUI.Views
{
    public sealed partial class SettingPage : Microsoft.UI.Xaml.Controls.Page
    {
        public SettingViewModel ViewModel { get; } = new SettingViewModel();

        public SettingPage()
        {
            this.InitializeComponent();
        }

        public class ImportBook
        {
            public string Desc { get; set; }
            public string Name { get; set; }
            public string Author { get; set; } // Thêm thuộc tính "Author"

            public string book_categories { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public int TotalSold { get; set; }

            public string toString()
            {
                return $"{Author}, {Desc}, {Name}, {Price}, {Quantity}, {TotalSold}";
            }
        }

        private async void ImportExcelButton_Click(object sender, RoutedEventArgs e)
        {
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
                                break;
                            }

                            if (currentRow == 1)  // Dòng 2 chứa tên các cột
                            {
                                // Bạn có thể xử lý tên cột ở đây nếu cần thiết
                                // Hiện tại, chúng ta sẽ không xử lý tên cột, vì nó đã được xác định trước
                                continue;
                            }

                            // Xác định cột và gán giá trị cho thuộc tính tương ứng của importBook
                            Debug.WriteLine("Current col: " + GetColumnName(cell.CellReference.Value));
                            //switch (GetColumnName(cell.CellReference.Value))
                            //{
                            //    case "book_categories":
                            //        importBook.book_categories = cellValue;
                            //        Debug.WriteLine("Case book_categories: " + cellValue + "/" + importBook.book_categories);
                            //        break;
                            //    case "author":
                            //        importBook.Author = cellValue;
                            //        Debug.WriteLine("Case author: " + cellValue + "/" + importBook.Author);
                            //        break;
                            //    case "desc":
                            //        importBook.Desc = cellValue;
                            //        Debug.WriteLine("Case desc: " + cellValue + "/" + importBook.Desc);
                            //        break;
                            //    case "name":
                            //        importBook.Name = cellValue;
                            //        Debug.WriteLine("Case name: " + cellValue + "/" + importBook.Name);
                            //        break;
                            //    case "price":
                            //        importBook.Price = int.Parse(cellValue);
                            //        Debug.WriteLine("Case price: " + cellValue + "/" + importBook.Price);
                            //        break;
                            //    case "quantity":
                            //        importBook.Quantity = int.Parse(cellValue);
                            //        Debug.WriteLine("Case quantity: " + cellValue + "/" + importBook.Quantity);
                            //        break;
                            //    case "total_sold":
                            //        importBook.TotalSold = int.Parse(cellValue);
                            //        Debug.WriteLine("Case total_sold: " + cellValue + "/" + importBook.TotalSold);
                            //        break;
                            //}

                            string columnName = GetColumnName(cell.CellReference.Value);
                            if (columnName.Equals("A"))
                            {
                                importBook.book_categories = cellValue;
                                Debug.WriteLine("Case book_categories: " + cellValue + "/" + importBook.book_categories);
                            } else if (columnName.Equals("B"))
                            {
                                importBook.Author = cellValue;
                                Debug.WriteLine("Case author: " + cellValue + "/" + importBook.Author);
                            } else if (columnName.Equals("C"))
                            {
                                importBook.Desc = cellValue;
                                Debug.WriteLine("Case desc: " + cellValue + "/" + importBook.Desc);
                            } else if (columnName.Equals("D"))
                            {
                                importBook.Name = cellValue;
                                Debug.WriteLine("Case name: " + cellValue + "/" + importBook.Name);
                            } else if (columnName.Equals("E"))
                            {
                                importBook.Price = int.Parse(cellValue);
                                Debug.WriteLine("Case price: " + cellValue + "/" + importBook.Price);
                            } else if (columnName.Equals("F"))
                            {
                                importBook.Quantity = int.Parse(cellValue);
                                Debug.WriteLine("Case quantity: " + cellValue + "/" + importBook.Quantity);
                            } else if (columnName.Equals("G"))
                            {
                                importBook.TotalSold = int.Parse(cellValue);
                                Debug.WriteLine("Case total_sold: " + cellValue + "/" + importBook.TotalSold);
                            }

                            cellValues.Add(cellValue);
                        }
                        Debug.WriteLine("importBook: " + importBook.toString());

                        // Bắt đầu lấy dữ liệu từ dòng tiếp theo sau tiêu đề
                        if (currentRow > 1)
                        {
                            // Add cell values to the list
                            listCategoryName.Add(importBook.book_categories);

                            // Break the loop when reaching the specified number of rows to import
                            if (--rowsToImport == 0)
                            {
                                break;
                            }

                            importBooks.Add(importBook);
                        }

                        currentRow++;
                    }
                }

                foreach (string categoryName in listCategoryName)
                {
                    Debug.WriteLine("[OnClick_func]: " + categoryName);
                }
                foreach (ImportBook book in importBooks)
                {
                    Debug.WriteLine("[OnClick_func]: " + book.Author + " " + book.Desc + " " + book.Name + " " + book.Price + " " + book.Quantity + " " + book.TotalSold);
                }

                WriteToJsonFile("out.json", listCategoryName, importBooks);
            }
        }


        private void WriteToJsonFile(string fileName, List<string> listCategoryName, List<ImportBook> importBooks)
        {
            foreach (string categoryName in listCategoryName)
            {
                Debug.WriteLine("[WriteToJsonFile_func]: " + categoryName);
            }
            foreach (ImportBook book in importBooks)
            {
                Debug.WriteLine("[WriteToJsonFile_func]: "
                    + book.Author
                    + " "
                    + book.Desc
                    + " "
                    + book.Name
                    + " "
                    + book.Price
                    + " "
                    + book.Quantity
                    + " "
                    + book.TotalSold);
            }
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
                categories = listCategoryName
            };

            string jsonContent = JsonSerializer.Serialize(jsonData, new JsonSerializerOptions { WriteIndented = true });
            Debug.WriteLine(jsonContent);

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

        private void IsEnabledToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {

        }
    }
}
