using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace DAO
{
    public sealed class Worker
    {
        private const String BASE_URL = "http://localhost:8080/api/v1";

        private readonly HttpClient _httpClient;

        private Worker()
        {
            _httpClient = new HttpClient();
        }

        public static Worker GetWorker() { 
            return new Worker(); 
        }



    }
}
