using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayerContract
{
    public abstract class IBus
    {
        protected IDAO _dao;

        public abstract AppVersion GetVersion();
        public abstract IBus CreateNew(IDAO dao);
        public abstract string OnData();

        public abstract dynamic Get(Dictionary<String, String> configuration);    // read
        public abstract dynamic Patch(Object entity, Dictionary<String, String> configuration);  // update
        public abstract dynamic Post(Object entity, Dictionary<String, String> configuration);   // create 
        public abstract dynamic Delete(Object entity, Dictionary<String, String> configuration); // delete
    }
}
