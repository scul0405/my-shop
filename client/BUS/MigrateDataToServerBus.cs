using System.Collections.Generic;
using ThreeLayerContract;

namespace BUS
{
    public class MigrateDataToServerBus : IBus
    {
        public MigrateDataToServerBus() { }
        public MigrateDataToServerBus(IDAO dao) { this._dao = dao; }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            return _dao.Post(entity, configuration);
        }

        public override IBus CreateNew(IDAO dao) => new MigrateDataToServerBus(dao);
        public override AppVersion GetVersion() => AppVersion.Default;
        public override string OnData() => "Migrate";

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            throw new System.NotImplementedException();
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            throw new System.NotImplementedException();
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            throw new System.NotImplementedException();
        }
    }
}
