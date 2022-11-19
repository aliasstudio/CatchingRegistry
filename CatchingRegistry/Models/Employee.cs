using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Organization Organization { get; set; }
        public Role Role { get; set; }
    }
}
