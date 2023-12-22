using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace BUS
{
    public class UserBus : IBus
    {
        // Identifier
        public override AppVersion GetVersion() => AppVersion.Default;

        public UserBus() { }
        public UserBus(IDAO dao) { this._dao = dao; }
        public override IBus CreateNew(IDAO dao) => new UserBus(dao);

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            return this._dao.Delete( configuration);
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            return this._dao.Get(configuration);
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            return this._dao.Patch(entity, configuration);
        }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            return this._dao.Post(entity, configuration);
        }

        public override string ToString() => "UserBus";
        public override string OnData() => "User";
    }
}
