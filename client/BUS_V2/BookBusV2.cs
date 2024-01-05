using System.Collections.Generic;
using ThreeLayerContract;

/*
 * Project này chỉ có duy nhất một class BookBusV2 
 * để demo ứng dụng có thể mở rộng theo mô hình 
 * plugin và pattern Dependency injection
 */

namespace BUS_V2
{
    /// <summary>
    /// Class này chỉ là để demo ứng dụng có thể mở rộng
    /// theo mô hình plugin nên phần implement hoàn toàn 
    /// giống như BookBus.
    /// </summary>
    public class BookBusV2 : IBus
    {
        public override string GetVersion() => "Sieu cap vippro123";
        public BookBusV2() { }
        public BookBusV2(IDAO dao) { this._dao = dao; }
        public override IBus CreateNew(IDAO dao) => new BookBusV2(dao);
        public override string OnData() => "Book";

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            // bussiness logic
            return this._dao.Delete(configuration);
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            // bussiness logic
            return this._dao.Get(configuration);
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            // bussiness logic
            return this._dao.Patch(entity, configuration);
        }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            // bussiness logic
            return this._dao.Post(entity, configuration);
        }
    }
}
