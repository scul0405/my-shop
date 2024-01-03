using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayerContract
{
    public abstract class IGUI : IVersion
    {
        protected Dictionary<string, IBus> _buses;
        public abstract string GetVersion();
        public abstract UserControl GetMainWindow();
        public abstract IGUI CreateNew(Dictionary<string, IBus> buses);
    }
}
