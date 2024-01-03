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
        public ReportPage()
        {
            this.InitializeComponent();
            this.DataContext = viewModel;
            ScreenStateManager.SaveLastScreen("ReportPage");

        }

        private void ClearFilter_Click(object sender, RoutedEventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
            StartDatePicker.SelectedDate = null;
            EndDatePicker.SelectedDate = null;
            viewModel.ClearFilter();
        }

        private void DatePicker_SelectedDateChanged(DatePicker sender, DatePickerSelectedValueChangedEventArgs args)
        {
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
                //eat
            }

        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.SelectedFilterIndex = FilterComboBox.SelectedIndex;
        }
    }
}
