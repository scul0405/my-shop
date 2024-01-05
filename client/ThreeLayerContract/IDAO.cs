using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using RestSharp;


namespace ThreeLayerContract
{
    public abstract class IDAO : IVersion
    {
        protected const String BASE_URL = "http://localhost:8080/api/v1";
        protected static RestClient _client = new(BASE_URL);
        
        public abstract string GetVersion();
        public abstract string OnData();
        public abstract dynamic Get(Dictionary<String, String> configuration);              // read
        public abstract dynamic Patch(Object entity, Dictionary<String, String> configuration);  // update
        public abstract dynamic Post(Object entity, Dictionary<String, String> configuration);   // create 
        public abstract dynamic Delete(Dictionary<String, String> configuration); // delete
    }
}