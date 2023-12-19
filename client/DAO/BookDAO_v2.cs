using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace DAO
{
    public class BookDAO_v2 : IDAO
    {
        public override dynamic Delete(object entity, Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override AppVersion GetVersion() => AppVersion.Vippro123;

        public override string OnData()
        {
            throw new NotImplementedException();
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }
    }
}
