using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchingRegistry.Models
{
    [Table("Employees")]
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Organization Organization { get; set; }
        public Role Role { get; set; }
    }
}
