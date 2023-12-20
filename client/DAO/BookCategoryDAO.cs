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
        public override AppVersion GetVersion() => AppVersion.Default;

        public BookCategoryDAO() {}
        public override dynamic Get(Dictionary<string, string> configuration)
        {
            var request = new RestRequest(Endpoint, Method.Get);
            try
            {
                var args = new
                {
                    size = configuration["size"],
                    page = configuration["page"]
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
