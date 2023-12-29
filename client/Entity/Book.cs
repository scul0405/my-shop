using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Book: INotifyPropertyChanged
    {
        public Book() { }

        public int ID { get; set; }
        public string author { get; set;}
        public int category_id { get; set;}
        public string desc { get; set;}
        public string name { get; set;}
        public int price { get; set;}
        public int quantity { get; set;}
        public bool status { get; set;}
        public int total_sold { get; set;}

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
