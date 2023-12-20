using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using ThreeLayerContract;

namespace DAO
{
    /*
     * Base route: /user
     * Configuration
     * - Route: 
     *      + "login" => tạo post request tới "/user/login"
     *      + "register" => tạo post request tới "/user/register"
     */
    public class UserDAO : IDAO
    {
        public override AppVersion GetVersion() => AppVersion.Default;

        public UserDAO() {
            //client.BaseAddress = new Uri($"{BASE_URL}/orders");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            return "OK";
        }

        public override string ToString() => "UserDAO";
        public override string OnData() => "User";
    }
}
