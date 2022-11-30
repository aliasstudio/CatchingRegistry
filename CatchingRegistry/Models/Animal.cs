using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CatchingRegistry.Models
{
    public class Animal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Features { get; set; }
        public int CatchingActID { get; set; }
    }
}
