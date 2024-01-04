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
using GUI.ViewModels;
using GUI;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReportPage : Page
    {
        ReportPageViewModel viewModel = new ReportPageViewModel();

        // Kiểm tra các case của filter
        // Nếu chọn ngày thì range không thể vượt quá 15 ngày
        // Không cho xem trước tương lai
        // Nếu chọn năm thì không vượt quá 10 năm
        // Nếu chọn tháng thì không vượt quá 1 năm
        // Nếu chọn tuần thì không vượt quá 2 tháng

        bool isClearFilterClicked = false;
        bool isInClearFilterProcess = false;
        string msg = "";
        int indexSelect = 0;
        DateTime from = DateTime.Now.AddDays(-7);
        DateTime to = DateTime.Now;
        public ReportPage()
        {
            this.InitializeComponent();
            this.DataContext = viewModel;
            ScreenStateManager.SaveLastScreen("ReportPage");

            from = viewModel.FromDate;
            to = viewModel.ToDate;

            StartDatePicker.SelectedDate = viewModel.FromDate;
            EndDatePicker.SelectedDate = viewModel.ToDate;
            
            Debug.WriteLine("ReportPage init");
            Debug.WriteLine("From: " + from.ToString("yyyy-MM-dd"));
            Debug.WriteLine("To: " + to.ToString("yyyy-MM-dd"));

            StartDatePicker.MaxYear = DateTime.Now;
            EndDatePicker.MaxYear = DateTime.Now;
            this.chart.Palette = GUI.ViewModels.CustomPalettes.CustomDark;
        }

        private void ClearFilter_Click(object sender, RoutedEventArgs e)
        {
            if (isClearFilterClicked)
            {
                return;
            }
            isClearFilterClicked = true;
            FilterComboBox.SelectedIndex = 0;

            StartDatePicker.SelectedDate = viewModel.FromDate;
            EndDatePicker.SelectedDate = viewModel.ToDate;

            from = viewModel.FromDate;
            to = viewModel.ToDate;

            msg = "";
            viewModel.ClearFilter();
            isClearFilterClicked = false;
        }

        private void resetFilter()
        {
            //FilterComboBox.SelectedIndex = 0;
            //StartDatePicker.SelectedDate = DateTime.Now.AddDays(-7);
            //EndDatePicker.SelectedDate = DateTime.Now;
        }

        private void DatePicker_SelectedDateChanged(DatePicker sender, DatePickerSelectedValueChangedEventArgs args)
        {
            Debug.WriteLine("DatePicker_SelectedDateChanged");
            Debug.WriteLine("From: " + from.ToString());
            Debug.WriteLine("To: " + to.ToString());
            // Nếu sự thay đổi đến từ reset filter thì không cần check
            if (isClearFilterClicked)
            {
                Debug.WriteLine("DatePicker_SelectedDateChanged isClearFilterClicked");
                Debug.WriteLine("From: " + from.ToString());
                Debug.WriteLine("To: " + to.ToString());
                try
                {
                    if (sender == StartDatePicker)
                    {
                        viewModel.FromDate = args.NewDate.Value.DateTime;
                    }
                    else if (sender == EndDatePicker)
                    {
                        viewModel.ToDate = args.NewDate.Value.DateTime;
                    }
                    

                }
                catch
                {
                    // eat

                }
            } 
            else
            {
                Debug.WriteLine("DatePicker_SelectedDateChanged  not isClearFilterClicked");
                Debug.WriteLine("From: " + from.ToString());
                Debug.WriteLine("To: " + to.ToString());
                if (sender == StartDatePicker)
                {
                    from = args.NewDate.Value.DateTime;

                }
                else if (sender == EndDatePicker)
                {
                    to = args.NewDate.Value.DateTime;
                }

                if (CheckValidDate(from, to, indexSelect))
                {
                    try
                    {
                        if (sender == StartDatePicker)
                        {
                            viewModel.FromDate = from;
                        }
                        else if (sender == EndDatePicker)
                        {
                            viewModel.ToDate = to;
                        }
                    }
                    catch
                    {
                        //eat
                    }
                }
                else
                {
                    ShowFailureMessage(msg);

                }
            }

        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexSelect = FilterComboBox.SelectedIndex;
            Debug.WriteLine("FilterComboBox_SelectionChanged");
            Debug.WriteLine("From: " + from.ToString());
            Debug.WriteLine("To: " + to.ToString());
            Debug.WriteLine("idx: " + indexSelect);
            if (CheckValidDate(from, to, indexSelect))
            {
                Debug.WriteLine("FilterComboBox_SelectionChanged valid");
                Debug.WriteLine("From: " + from.ToString());
                Debug.WriteLine("To: " + to.ToString());
                Debug.WriteLine("idx: " + indexSelect);
                viewModel.SelectedFilterIndex = FilterComboBox.SelectedIndex;
                Debug.WriteLine(" viewModel.SelectedFilterIndex " + viewModel.SelectedFilterIndex.ToString());
            } else
            {
                ShowFailureMessage(msg);
            }
        }

        bool CheckValidDate(DateTime from, DateTime to, int idx)
        {
            Debug.WriteLine("Check valid date");
            Debug.WriteLine("From: " + from.ToString());
            Debug.WriteLine("To: " + to.ToString());
            Debug.WriteLine("idx: " + idx);
            bool flag = true;
            if (from > to)
            {
                flag = false;
                msg = "Start date must be before end date";
            }
            // from < to
            else if (to > DateTime.Now)
            {
                flag = false;
                msg = "End date must be before today";
            }
            // from < to < now
            else if (idx == 0)
            {
                if (to.Subtract(from).TotalDays > 8)
                {
                    flag = false;
                    msg = "Date range must be less than 8 days";
                }
            }
            else if (idx == 1)
            {
                if (to.Subtract(from).TotalDays > 62)
                {
                    flag = false;
                    msg = "Date range must be less than 2 months";
                }
            }
            else if (idx == 2)
            {
                if (to.Subtract(from).TotalDays > 310)
                {
                    flag = false;
                    msg = "Date range must be less than 10 months";
                }
            }
            else if (idx == 3)
            {
                if (to.Subtract(from).TotalDays > 3650)
                {
                    flag = false;
                    msg = "Date range must be less than 10 years";
                }
            }

            return flag;
        }

        private async void ShowFailureMessage(string msg)
        {
            // Hiển thị thông báo đăng nhập không thành công
            var failureDialog = new ContentDialog
            {
                Title = "Invalid Filter",
                Content = msg,
                CloseButtonText = "OK"
            };

            if (failureDialog.XamlRoot != null)
            {
                failureDialog.XamlRoot = null;
            }

            failureDialog.CloseButtonClick += (sender, args) =>
            {
                resetFilter();
            };

            failureDialog.XamlRoot = this.Content.XamlRoot;

            await failureDialog.ShowAsync().AsTask();
        }
    }
}
