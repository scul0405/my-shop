using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order
    {
        public List<dynamic> books { get; set; }
        public Order() { }
        public int Id { get; set; }
        public DateTime created_at { get; set; }
        public bool status { get; set; }
        public int total { get; set; }
    }
}
