using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry.Models
{
    public class Animal
    {
        public string ID { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Features { get; set; }
    }
}
