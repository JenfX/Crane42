using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Item
    {
        public int ID { get; set; }
        public string CatNumber { get; set; }
        public string Naming { get; set; }
        public Unit Unit { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
