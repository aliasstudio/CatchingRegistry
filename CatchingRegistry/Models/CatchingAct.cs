using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchingRegistry.Models
{
    public class CatchingAct
    {
        public int ID { get; set; }
        public ICollection<Animal>? Animals { get; set; }
        public DateTime DateTime { get; set; }
        public MunicipalContract? MunicipalContract { get; set; }
        public string CatchingPurpose { get; set; }
        public string CatchingAddress { get; set; }
        public ICollection<File>? AttachedFiles { get; set; }
    }
}
