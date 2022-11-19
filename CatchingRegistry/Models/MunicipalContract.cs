using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Models
{
    public class MunicipalContract
    {
        public int ID { get; set; }
        public DateTime ContractDate { get; set; }
        public string MunicipalName { get; set; }
        public string LocalGovernment { get; set; }
        public Organization Organization { get; set; }

    }
}
