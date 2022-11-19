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
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime ContractDate { get; set; }
        [Required]
        public string MunicipalName { get; set; }
        [Required]
        public string LocalGovernment { get; set; }
        [Required]
        public Organization Organization { get; set; }

    }
}
