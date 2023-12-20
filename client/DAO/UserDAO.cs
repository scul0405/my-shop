using Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using ThreeLayerContract;
using Windows.ApplicationModel.Contacts;

namespace DAO
{
    /*
     * Base route: /users
     * Configuration
     * - type: 
     *      + "login" => tạo post request tới "/users/login"
     *      + "register" => tạo post request tới "/users/register"
     */
    public class UserDAO : IDAO
    {
        private const string Endpoint = "/users";
        public override AppVersion GetVersion() => AppVersion.Default;

        public UserDAO() { }

        /*
         * Example
         * - Register
         *  var configuration = new Dictionary<string, string> {
         *       { "type", "register" },                           
         *  };
         *  
         * - Login
         *  var configuration = new Dictionary<string, string> {
         *       { "type", "login" },                           
         *  };
         */
        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            var request = new RestRequest($"{Endpoint}/{configuration["type"]}", Method.Post);
            request.AddBody((User)entity);

            return _client.ExecutePost(request).IsSuccessful;
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

        public override string ToString() => "UserDAO";
        public override string OnData() => "User";
    }
}
