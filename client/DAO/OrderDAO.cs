using Entity;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using ThreeLayerContract;

namespace DAO
{
    /*
     * Configuration:
     * - id: 
     *      không có id -> route vào /orders
     *      có id -> route vào /orders/{id}
     *      
     * (1) /orders
     * - GET: 
     *      + Page: index trang
     *      + Size: số order mỗi trang
     *      + Date from: yyyy-mm-dd
     *      + Date to: yyyy-mm-dd
     * - POST: 
     * không
     * 
     * (2) /orders/{id}
     * - GET/PATCH/DELETE: không
     * - POST:
     *      + route vào /orders/{id}/books/{bid}
     *      + bid: book id
     */
    public class OrderDAO : IDAO
    {
        private const string Endpoint = "/orders";
        public override AppVersion GetVersion() => AppVersion.Default; 

        public OrderDAO() { }

        /*
         * Example
         * - Get all order
         *  var configuration = new Dictionary<string, string> {
         *       { "page", "2" },                            [optional]
         *       { "size", "2" },                            [optional]
         *       { "from", "1999/12/20" },                   [optional]
         *       { "to", "2000/12/20" },                     [optional]
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
                var request = new RestRequest($"{Endpoint}/{id}", Method.Get);
                var response = _client.ExecuteGet(request);

                if (!response.IsSuccessful) { return null; }

                var result = JsonConvert.DeserializeObject<Order>(response.Content);
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

                var result = JsonConvert.DeserializeObject<HttpResponse<Order>>(response.Content);
                return result.list;
            }
        }

        public override dynamic Patch(Object entity, Dictionary<string, string> configuration)
        { 
            var order = (Order)entity;
            var request = new RestRequest($"{Endpoint}/{order.Id}", Method.Patch);
            request.AddBody(order);

            return _client.Execute(request).IsSuccessful;
        }

        public override dynamic Post(Object entity, Dictionary<string, string> configuration)
        {
            string id;
            RestRequest request;

            if (configuration != null && configuration.TryGetValue("id", out id))
            {
                try
                {
                    request = new RestRequest($"{Endpoint}/{id}/books/{configuration["bid"]}", Method.Post);
                } 
                catch (KeyNotFoundException)
                {
                    throw new Exception("Error at OrderDAO - Post request for adding book to order must provide params 'bid'");
                }
            }
            else
            {
                var order = (Order)entity;
                request = new RestRequest(Endpoint, Method.Post);
                request.AddBody(order);
            }

            return _client.ExecutePost(request).IsSuccessful;
        }

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            try
            {
                var request = new RestRequest($"{Endpoint}/{configuration["id"]}", Method.Delete);

                return _client.Execute(request).IsSuccessful;
            }
            catch (KeyNotFoundException)
            {
                throw new Exception("Error at OrderDAO - Delete method must include ID parameter.\"");
            }
        }

        public override string ToString() => "OrderDAO";
        public override string OnData() => "Order";
    }
}
