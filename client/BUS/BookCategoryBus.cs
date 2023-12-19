using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace BUS
{
    public class BookCategoryBus : IBus
    {
        public override AppVersion GetVersion() => AppVersion.Default;
        
        public BookCategoryBus() { }

        public BookCategoryBus(IDAO dao) { this._dao = dao; }
        
        public override IBus CreateNew(IDAO dao) => new BookCategoryBus(dao);

        public override dynamic Delete(object entity, Dictionary<string, string> configuration)
        {
            return this._dao.Delete(entity, configuration);
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
        public override string ToString() => "BookCategoryBus";
        public override string OnData() => "BookCategory";
    }
}
