using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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
        public override AppVersion GetVersion() => AppVersion.Default; 

        public OrderDAO() 
        {
            //client.BaseAddress = new Uri($"{BASE_URL}/orders");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override dynamic Patch(Object entity, Dictionary<string, string> configuration)
        { 
            return "OK";
        }

        public override dynamic Post(Object entity, Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override string ToString() => "OrderDAO";
        public override string OnData() => "Order";
    }
}
