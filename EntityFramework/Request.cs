using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    /*public class Request
        {
            public int ID { get; set; }
            public DateTime DateTime { get; set; }
            public string Client { get; set; }
            public string TelNumber { get; set; }
            public string Address { get; set; }
            public string Tariff { get; set; }
            public int WorkTime { get; set; }
            public int Driver { get; set; }
            public int Crane { get; set; }
            public string Comment { get; set; }
        }*/

    public class Request
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int Driver { get; set; }
    }
}
