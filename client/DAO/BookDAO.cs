using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerContract;

namespace DAO
{
    /*
     * Configuration:
     * - id: 
     *      + Nếu có id: routing vào /books/{id}
     *      + Nếu không có id: routing vào /books
     *      
     * (1) /books
     * - GET: 
     *      + page: Thứ tự trang
     *      + size: Số sản phẩm mỗi trang
     *      + name: get theo tên sách
     *      + min/max price: tìm theo khoảng giá
     *      + category name: tìm theo tên category
     * - POST:
     *      không 
     *      
     * (2) /books/{id}
     *      không 
     */
    public class BookDAO : IDAO
    {
        public override AppVersion GetVersion() => AppVersion.Default;

        public BookDAO() { 
            //client.BaseAddress = new Uri($"{BASE_URL}/orders");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public override dynamic Get(Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override dynamic Delete(object entity, Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override string ToString() => "BookDAO";
        public override string OnData() => "Book";
    }
}
