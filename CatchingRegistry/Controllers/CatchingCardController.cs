using CatchingRegistry.Models;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;


namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        private static CatchingCardController instance;
        static ApplicationContext ctx = new();

        public static CatchingCardController GetInstance()
        {
            if (instance == null)
                instance = new CatchingCardController();
            ctx = new();
            return instance;
        }

        public static CatchingAct GetByID(int actID) => ctx.CatchingActs.Find(actID);
        public static void Delete(int actID) => ctx.CatchingActs.Remove(GetByID(actID));

        public static void Save(CatchingAct catchingAct)
        {
            var act = GetByID(catchingAct.ID);

            if (act != null)
                ctx.CatchingActs.Update(act);
            else
                ctx.CatchingActs.Add(act);

            ctx.SaveChanges();

        }


        public static void AddAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals.Add(animal);
        public static void EditAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals
            [catchingAct.Animals.IndexOf(
                catchingAct.Animals.FirstOrDefault(x => x.ID == animal.ID)
            )] = animal;
        public static void RemoveAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals.Remove(animal);

        public static void UpdateFiles(CatchingAct newCatchingAct)
        {
            var programPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            var fileSavePath = @$"{programPath}\Files\municipal{newCatchingAct.MunicipalContractID}\act{newCatchingAct.ID}";

            foreach (var file in newCatchingAct.Files)
            {
                var fileName = file.Path.Split("\\");
                if (fileName.Length > 1)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(@$"{fileSavePath}\"));
                    File.Copy(file.Path, @$"{fileSavePath}\{fileName.Last()}");
                    file.Path = fileName.Last();
                }
            }

            string[] files = Directory.GetFiles(fileSavePath).Select(file => file.Split("\\").Last()).ToArray();

            foreach (var fileName in files)
                if (!newCatchingAct.Files.Select(x => x.Path).Contains(fileName))
                    File.Delete(@$"{fileSavePath}\{fileName}");
        }

        public static List<AttachedFile> GetAllFiles(CatchingAct catchingAct)
        {
            return ctx.CatchingActs.Single(x => x.ID == catchingAct.ID).Files;
        }

        public static void ExportToWord(CatchingAct catchingAct)
        {

        }
    }
}
