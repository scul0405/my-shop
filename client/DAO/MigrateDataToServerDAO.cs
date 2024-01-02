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
            if (entity is string)
            {
                Debug.WriteLine("String paraaaaaaaa");
                request.AddBody(entity);
            } else
            {
                request.AddBody(entity);
            }
            Debug.WriteLine("Request: " + request.ToString());
            return _client.ExecutePost(request).IsSuccessful;
        }

        public override AppVersion GetVersion() => AppVersion.Default;
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
