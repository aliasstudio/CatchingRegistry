using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry.Models
{
    public class Animal
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Features { get; set; }
    }
}
