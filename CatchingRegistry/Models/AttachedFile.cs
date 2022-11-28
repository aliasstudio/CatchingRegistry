using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchingRegistry.Models
{
    [Table("Files")]
    public class AttachedFile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CatchingActID { get; set; }
    }
}
