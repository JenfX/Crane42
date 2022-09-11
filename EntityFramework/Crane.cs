using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Crane
    {
        public int ID { get; set; }
        public string Naming { get; set; }
        public string Number { get; set; }
        public List<Item> Parts { get; set; }
    }
}
