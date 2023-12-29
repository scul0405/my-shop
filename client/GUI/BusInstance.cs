using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace GUI
{
    public static class BusInstance
    {
        public static Dictionary<string, IBus> _bus;
    }
}
