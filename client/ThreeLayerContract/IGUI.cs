using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayerContract
{
    public abstract class IGUI
    {
        protected Dictionary<string, IBus> _buses;
        public abstract AppVersion GetVersion();
        public abstract UserControl GetMainWindow();
        public abstract IGUI CreateNew(Dictionary<string, IBus> buses);
    }
}
