using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchingRegistry.Models
{
    [Table("Files")]
    public class File
    {
        public int ID { get; set; }
        public string Path { get; set; }

        public int CatchingActID { get; set; }
    }
}
