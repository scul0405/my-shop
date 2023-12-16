using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Order
    {
        public Order() { }

        public int Id { get; set; }
        public List<Book> books { get; set; }
        public DateTime created_at { get; set; }
        public bool status { get; set; }
        public int total { get; set; }
    }
}
