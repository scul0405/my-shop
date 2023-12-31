using CommunityToolkit.Labs.WinUI;
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
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingPage : Page
    {
        public SettingViewModel ViewModel { get; } = new SettingViewModel();

        public SettingPage()
        {
            this.InitializeComponent();
        }

        private void SettingsCard_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void IsEnabledToggleSwitch_Toggled(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            if (sender is not ToggleSwitch toggleSwitch)
            {
                return;
            }

            foreach (SettingsCard item in this.MultipleItemsSettingsExpander.Items.OfType<SettingsCard>())
            {
                item.IsEnabled = toggleSwitch.IsOn;
            }
        }

        private async Task<List<BookCategory>> ReadBookCategoriesFromCsvAsync(Windows.Storage.StorageFile file)
        {
            List<BookCategory> bookCategories = new List<BookCategory>();

            try
            {
                using (var stream = await file.OpenStreamForReadAsync())
                using (var reader = new StreamReader(stream))
                using (var csvParser = new TextFieldParser(reader))
                {
                    csvParser.SetDelimiters(new string[] { "," }); // Đặt ký tự phân cách CSV của bạn

                    // Bỏ qua tiêu đề nếu có
                    if (!csvParser.EndOfData)
                        csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        string[] fields = csvParser.ReadFields();
                        if (fields != null && fields.Length > 0)
                        {
                            // Giả sử trường đầu tiên là cột 'Name'
                            string name = fields[0];
                            BookCategory category = new BookCategory { Name = name };
                            bookCategories.Add(category);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ, ví dụ, tệp không tìm thấy, định dạng CSV không hợp lệ, vv.
                Debug.WriteLine($"Lỗi đọc tệp CSV: {ex.Message}");
            }

            return bookCategories;
        }

        private async void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new FileOpenPicker();
            openFileDialog.FileTypeFilter.Add(".csv");

            var selectedFile = await openFileDialog.PickSingleFileAsync();
            if (selectedFile != null)
            {
                // Bây giờ bạn đã có tệp đã chọn. Bạn có thể sử dụng nó theo cách cần.
                // Ví dụ, bạn có thể gọi phương thức để đọc BookCategories từ tệp CSV.
                List<BookCategory> bookCategories = await ReadBookCategoriesFromCsvAsync(selectedFile);
            }
        }

    }
}
