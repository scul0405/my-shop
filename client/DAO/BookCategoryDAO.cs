using Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ThreeLayerContract;
using Newtonsoft.Json;

namespace DAO
{
    /*
     * Configuration:
     * - size: số sản phẩm mỗi trang
     * - page: số trang
    */
    public class BookCategoryDAO : IDAO
    {
        private const string Endpoint = "/book_categories";
        public override string GetVersion() => "Default";

        public BookCategoryDAO() {}
  
        /*
         * Example:
         * var configuration = new Dictionary<string, string> { 
         *          { "page", "2" },        [optional]
         *          { "size", "2" }         [optional]
         * }
         * => request sẽ là BASE_URL/book_categories?page=2&size=2
         */
        public override dynamic Get(Dictionary<string, string> configuration)
        {
            var request = new RestRequest(Endpoint, Method.Get);

            try
            {
                // if configuration is null, then create an empty config
                configuration ??= new Dictionary<string, string>(); 

                var args = new
                {
                    size = configuration["size"],
                    page = "1"
                };

                request.AddObject(args);
            } 
            catch (KeyNotFoundException) { /* no parameter is required */ }

            var response = _client.ExecuteGet(request);
            if (response == null || !response.IsSuccessful) {  return null; }
            
            var result = JsonConvert.DeserializeObject<HttpResponse<BookCategory>>(response.Content);
            return result.list;
        }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            var bookCategory = (BookCategory)entity;
            var request = new RestRequest(Endpoint, Method.Post);
            request.AddBody(bookCategory);

            return _client.ExecutePost(request).IsSuccessful;
        }
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
                throw new Exception("Error at BookCategoryDAO - Delete method must include ID parameter.");
            }
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            var bookCategory = (BookCategory)entity;
            var request = new RestRequest($"{Endpoint}/{bookCategory.Id}", Method.Patch);
            request.AddBody(bookCategory);

            return _client.Execute(request).IsSuccessful;
        }

        public override string OnData() => "BookCategory";
    }
}
