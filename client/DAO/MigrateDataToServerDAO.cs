using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using ThreeLayerContract;


namespace DAO
{
    class MigrateDataToServerDAO : IDAO
    {
        private const string Endpoint = "import";

        public override dynamic Post(object entity, Dictionary<string, string> configuration)
        {
            var request = new RestRequest(Endpoint, Method.Post);
            request.AddBody(entity);
            return _client.ExecutePost(request).IsSuccessful;
        }
        
        public override string GetVersion() => "Default";
        public override string OnData() => "Migrate";

        public override dynamic Delete(Dictionary<string, string> configuration)
        {
            throw new System.NotImplementedException();
        }

        public override dynamic Get(Dictionary<string, string> configuration)
        {
            throw new System.NotImplementedException();
        }

        public override dynamic Patch(object entity, Dictionary<string, string> configuration)
        {
            throw new System.NotImplementedException();
        }
    }
}
