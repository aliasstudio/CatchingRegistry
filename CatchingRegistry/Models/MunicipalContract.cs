using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CatchingRegistry.Models
{
    public class MunicipalContract
    {
        public int ID { get; set; }
        public string ContractDate { get; set; }

        // муниципальное образование
        public string Municipality { get; set; }

        // подрядчик
        public Organization Contractor { get; set; }

        // администрация и т.д.
        public Organization LocalGovernment { get; set; }
    }
}
