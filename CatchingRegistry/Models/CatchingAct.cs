using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CatchingRegistry.Services;

namespace CatchingRegistry.Models
{
    public class CatchingAct
    {
        private readonly ObservableListSource<Animal> animals = new ObservableListSource<Animal>();
        private readonly ObservableListSource<File> files = new ObservableListSource<File>();
        public int ID { get; set; }
        public string Date { get; set; }
        public int MunicipalContractID { get; set; }
        public string CatchingPurpose { get; set; }
        public string CatchingAddress { get; set; }
        public MunicipalContract MunicipalContract { get; set; }
        public ObservableListSource<Animal> Animals { get { return animals; } }
        public ObservableListSource<File> Files { get { return files; } }
    }
}
