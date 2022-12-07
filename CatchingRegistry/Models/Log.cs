using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Models
{
    public class Log
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Date { get; set; }
        public string Operation { get; set; }
        public string Parameters { get; set; }
    }
}
