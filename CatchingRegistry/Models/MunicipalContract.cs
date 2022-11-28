using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CatchingRegistry.Models
{
    public class MunicipalContract
    {
        public int ID { get; set; }
        public string ContractDate { get; set; }
        public string MunicipalName { get; set; }
        public string LocalGovernment { get; set; }
        public virtual Organization Organization { get; set; }

    }
}
