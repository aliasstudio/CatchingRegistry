using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry.Models
{
    public class CatchingAct
    {
        public int ID { get; set; }
        public ICollection<Animal> Animals { get; set; }
        public DateTime DateTime { get; set; }
        public MunicipalContract MunicipalContract { get; set; }
        public string CatchingPurpose { get; set; }
        public string CatchingAddress { get; set; }
    }
}
