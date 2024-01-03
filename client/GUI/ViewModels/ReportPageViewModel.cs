using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace GUI.ViewModels
{
    class ReportPageViewModel : ObservableObject
    {
        private ObservableCollection<string> filterOptions;
        private Dictionary<string, IBus> _bus = BusInstance._bus;
        private DateTime _fromDate = DateTime.MinValue;
        private DateTime _toDate = DateTime.MaxValue;
        private int selectedFilterIndex = 0;
        // 0 - By Day, 1 - By Week, 2 - By Month, 3 - By Year

        public int SelectedFilterIndex
        {
            get { return selectedFilterIndex; }
            set
            {
                if (selectedFilterIndex != value)
                {
                    selectedFilterIndex = value;
                    OnPropertyChanged(nameof(SelectedFilterIndex));
                    Debug.WriteLine("[SelectedFilterIndex]: Change, val: " + selectedFilterIndex);
                }
            }
        }

        public ObservableCollection<string> FilterOptions
        {
            get { return filterOptions; }
            set
            {
                if (filterOptions != value)
                {
                    filterOptions = value;
                    OnPropertyChanged(nameof(FilterOptions));
                }
            }
        }

        public void ClearFilter()
        {
            Debug.WriteLine("[ClearFilter]: onlick");
            // Xóa bộ lọc và cập nhật dữ liệu
            FromDate = DateTime.MinValue;
            ToDate = DateTime.MaxValue;
            SelectedFilterIndex = 0;

            // Gọi Refresh để cập nhật dữ liệu mới
            //Refresh();
        }

        public DateTime ToDate
        {
            get { return _toDate; }
            set
            {
                if (_toDate != value)
                {
                    
                    SetProperty(ref _toDate, value);
                    Debug.WriteLine("[ToDate]: Change, val: " + _toDate.ToString("yyyy-MM-dd"));
                    //Refresh();
                }
            }
        }

        public DateTime FromDate
        {
            get { return _fromDate; }
            set
            {
                if (_fromDate != value)
                {
                    
                    SetProperty(ref _fromDate, value);
                    Debug.WriteLine("[FromDate]: Change, val: " + _fromDate.ToString("yyyy-MM-dd"));
                    //Refresh();
                }
            }
        }

        public ReportPageViewModel()
        {
            FilterOptions = new ObservableCollection<string>
            {
                "By Day",
                "By Week",
                "By Month",
                "By Year"
            };
        }



    }
}
