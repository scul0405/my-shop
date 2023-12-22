using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayerContract
{
    public class HttpResponse<T>
    {
        public HttpResponse() { }
        public int total_pages;
        public int total_count;
        public int size;
        public bool has_more;
        public int page;
        public List<T> list;
    }
}
