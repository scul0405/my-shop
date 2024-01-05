using Entity;
using Newtonsoft.Json;
using RestSharp;
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
        private const string Endpoint = "/books";
        public override string GetVersion() => "Default";

        public BookDAO() { }

        /*
         * Example
         * - Get all book
         *  var configuration = new Dictionary<string, string> {
         *       { "page", "2" },                            [optional]
         *       { "size", "2" },                            [optional]
         *       { "name", "Làm Đĩ" },                       [optional]
         *       { "min", "200" },                           [optional]
         *       { "max", "400" },                           [optional]
         *       { "category_name", "Self help chữa lành" }  [optional]
         *  };
         *  
         *  - Get book by id
         *  var configuration = new Dictionary<string, string> { { "id", "2" } };
         */
        public override dynamic Get(Dictionary<string, string> configuration)
        {
            string id;

            if (configuration != null && configuration.TryGetValue("id", out id))
            {
                // handle book detail
                var request = new RestRequest($"{Endpoint}/{id}", Method.Get);
                var response = _client.ExecuteGet(request);

                if (!response.IsSuccessful) { return null; }

                var result = JsonConvert.DeserializeObject<Book>(response.Content);
                return result;
            }
            else
            {
                var request = new RestRequest(Endpoint, Method.Get);
                foreach (KeyValuePair<string, string> entry in configuration)
                {
                    request.AddParameter(entry.Key, entry.Value);
                }

                var response = _client.ExecuteGet(request);

                if (!response.IsSuccessful) { return null; }

                var result = JsonConvert.DeserializeObject<HttpResponse<Book>>(response.Content);
                return result.list;
            }
        }
        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            var book = (Book)entity;
            var request = new RestRequest(Endpoint, Method.Post);
            request.AddBody(book);

            return _client.ExecutePost(request).IsSuccessful;
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            var book = (Book)entity;
            var request = new RestRequest($"{Endpoint}/{book.ID}", Method.Patch);
            request.AddBody(book);

            return _client.Execute(request).IsSuccessful;
        }

        /*
         * Example
         * - Delete book by id
         *  var configuration = new Dictionary<string, string> { { "id", "2" } };
         */
        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            try
            {
                // if configuration is null, then create an empty config
                configuration ??= new Dictionary<string, string>();

                var request = new RestRequest($"{Endpoint}/{configuration["id"]}", Method.Delete);

                return _client.Execute(request).IsSuccessful;
            }
            catch (KeyNotFoundException)
            {
                throw new Exception("Error at BookDAO - Delete method must include ID parameter.\"");
            }
        }
        public override string OnData() => "Book";
    }
}
