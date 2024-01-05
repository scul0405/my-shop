using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    public class SettingViewModel : INotifyPropertyChanged
    {
        private string selectedTheme;

        public string SelectedTheme
        {
            get { return selectedTheme; }
            set
            {
                if (selectedTheme != value)
                {
                    selectedTheme = value;
                    OnPropertyChanged(nameof(SelectedTheme));
                    UpdateAppTheme();
                }
            }
        }

        private void UpdateAppTheme()
        {
            switch (SelectedTheme)
            {
                case "Default":
                    Application.Current.RequestedTheme = ApplicationTheme.Light; // Set a default theme if needed
                    break;

                case "Light":
                    Application.Current.RequestedTheme = ApplicationTheme.Light;
                    break;

                case "Dark":
                    Application.Current.RequestedTheme = ApplicationTheme.Dark;
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}


