using CatchingRegistry.Models;
using Word = Microsoft.Office.Interop.Word;
using File = CatchingRegistry.Models.File;


namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        static ApplicationContext context = new();

        public static CatchingAct GetByID(int actID) => context.CatchingActs.Find(actID);
        public static void Delete(int actID) => context.CatchingActs.Remove(GetByID(actID));

        public static void Save(CatchingAct catchingAct)
        {
            var act = GetByID(catchingAct.ID);
            if (act != null)
                context.CatchingActs.Update(act);
            else
                context.CatchingActs.Add(act);

            context.SaveChanges();
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

        public static void UploadFile(CatchingAct catchingAct, string fileName, int catchingActID)
        {
         
        }
    }
}
