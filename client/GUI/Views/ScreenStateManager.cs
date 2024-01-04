using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace GUI.Views
{
    public static class ScreenStateManager
    {
        private const string LastScreenKey = "LastScreen";

        public static void SaveLastScreen(string screenName)
        {
            // Lưu tên trang vào LocalSettings
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values[LastScreenKey] = screenName;
        }

        public static string GetLastScreen()
        {
            // Lấy tên trang từ LocalSettings
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            if (localSettings.Values.TryGetValue(LastScreenKey, out object lastScreen))
            {
                return lastScreen.ToString();
            }

            return "Dashboard";
        }
    }
}
