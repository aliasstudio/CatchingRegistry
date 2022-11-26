using CatchingRegistry.Models;
using Word = Microsoft.Office.Interop.Word;

namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        static ApplicationContext ctx = new();

        public static CatchingAct GetByID(int actID) => ctx.CatchingActs.Find(actID);
        public static void Delete(int actID) => ctx.CatchingActs.Remove(GetByID(actID));

        public static void Save(CatchingAct catchingAct)
        {
            var act = GetByID(catchingAct.ID);
            if (act != null)
                ctx.CatchingActs.Update(act);
            else
                ctx.CatchingActs.Add(act);
        }

        public static void AddAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals.Add(animal);
        public static void EditAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals
            [catchingAct.Animals.IndexOf(
                catchingAct.Animals.FirstOrDefault(x => x.ID == animal.ID)
            )] = animal;
        public static void RemoveAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals.Remove(animal);

        public static void ExportToWord(CatchingAct catchingAct)
        {

        }
    }
}
