using Entity;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace GUI
{
    public class IdToCategoryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int id = (int)value;
            Dictionary<string, IBus> _bus = BusInstance._bus;
            var configuration = new Dictionary<string, string>();
            List<BookCategory> bookCategories = new List<BookCategory>(_bus["BookCategory"].Get(configuration));

            string res = bookCategories.Find(x => x.Id == id).Name;
            //string res = "2";
            return res;
        }

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
