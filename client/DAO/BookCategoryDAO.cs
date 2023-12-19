using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace DAO
{
    /*
     * Configuration:
     * - size: số sản phẩm mỗi trang
     * - page: số trang
    */
    public class BookCategoryDAO : IDAO
    {
        public override AppVersion GetVersion() => AppVersion.Default;

        public BookCategoryDAO() {
            //client.BaseAddress = new Uri($"{BASE_URL}/orders");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public override dynamic Get(Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            return "OK";
        }
        public override dynamic Delete(object entity, Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => "BookCategoryDAO";

        public override string OnData() => "BookCategory";
    }
}
