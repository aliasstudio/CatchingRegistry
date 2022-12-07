using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchingRegistry.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Posibility { get; set; }

        public int Visibility { get; set; }

        public enum PosibilityType
        {
            Redactor = 0,
            Observer = 1
        }
        public enum VisibilityType
        {
            All = 0,
            Organization = 1,
            Municipality = 2
        }
    }
}
