using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Models
{
    public class Organization
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
