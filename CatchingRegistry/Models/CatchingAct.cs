using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CatchingRegistry.Services;

namespace CatchingRegistry.Models
{
    public class CatchingAct
    {
        private readonly ObservableListSource<Animal> animals = new();
        private readonly ObservableListSource<File> files = new();
        public int ID { get; set; }
        public string Date { get; set; }
        public int MunicipalContractID { get; set; }
        public string CatchingPurpose { get; set; }
        public string CatchingAddress { get; set; }
        public virtual MunicipalContract MunicipalContract { get; set; }
        public virtual ObservableListSource<Animal> Animals { get { return animals; } }
        public virtual ObservableListSource<File> Files { get { return files; } }
    }
}
