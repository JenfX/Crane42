using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Waybill
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Crane Crane { get; set; }
        public Driver Driver { get; set; }
        public double WorkTime { get; set; }
        public Customer Customer { get; set; }
        public WorkObject WorkObject { get; set; }
        public string Address { get; set; }
        public int Tariff { get; set; }
        public int Payment { get; set; }
        
        public int Refill { get; set; }
        public int RefillPrice { get; set; }
    }
}
