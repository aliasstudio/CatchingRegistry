using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchingRegistry.Models
{
    public class CatchingAct
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public int MunicipalContractID { get; set; }
        public string CatchingPurpose { get; set; }
        public string CatchingAddress { get; set; }
        public virtual MunicipalContract MunicipalContract { get; set; }
        public virtual List<Animal> Animals { get; set; }
        public virtual List<AttachedFile> Files { get; set; }
    }
}
