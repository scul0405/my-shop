using System;
using System.Collections.Generic;

namespace Entity
{
    public class OrderBooks
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
    }

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
