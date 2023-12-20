using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;
using ThreeLayerContract;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BUS
{
    public class OrderBus : IBus
    {
        public override AppVersion GetVersion() => AppVersion.Default;
        
        public OrderBus() { }
        public OrderBus(IDAO dao) { _dao = dao; }

        public override IBus CreateNew(IDAO dao) => new OrderBus(dao);

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            // business logic here
            return _dao.Delete(configuration);
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            // business logic here
            return _dao.Get(configuration);
        }

        public override dynamic Patch(Object entity, Dictionary<string, string> configuration)
        {
            // business logic here
            return _dao.Patch(entity, configuration);
        }

        public override dynamic Post(Object entity, Dictionary<string, string> configuration)
        {
            // business logic here
            return _dao.Post(entity, configuration);
        }

        public override string ToString() => "OrderBus";
        public override string OnData() => "Order";
    }
}
