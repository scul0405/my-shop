using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class Utils
    {
        public static String ParseParameter(Dictionary<string, string> configuration)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('?');
        
            return builder.ToString();
        }
    }
}
