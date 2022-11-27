using CatchingRegistry.Models;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;


namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        private static CatchingCardController instance;
        static ApplicationContext ctx = new();
        static List<FileStream> AttachedFiles = new List<FileStream>();

        public static CatchingCardController GetInstance()
        {
            if (instance == null)
                instance = new CatchingCardController();
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

        public static void UploadFile(CatchingAct catchingAct, string filePath)
        {
            //var programPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            //var fileSavePath = @$"{programPath}\Files\municipal{catchingAct.MunicipalContractID}\act{catchingAct.ID}";
            //var fileName = filePath.Split("\\").Last();
            //var absolutePath = @$"\Files\municipal{catchingAct.MunicipalContractID}\act{catchingAct.ID}\{fileName}";
            AttachedFiles.Add(File.Create(filePath));
            //catchingAct.Files.Add(new AttachedFile() { Path = absolutePath, CatchingActID = catchingAct.ID });

            //Directory.CreateDirectory(Path.GetDirectoryName(@$"{fileSavePath}\"));

            //if (!File.Exists($@"{fileSavePath}\{fileName}"))
            //{
            //AttachedFiles.Add(File.Create(filePath));
            //File.Copy(filePath, @$"{fileSavePath}\{fileName}");
                //catchingAct.Files.Add(new AttachedFile() { Path = fileSavePath, CatchingActID = catchingAct.ID });
            //}
        }
        public static void RemoveFile(CatchingAct catchingAct, int fileID)
            => catchingAct.Files.RemoveAt(fileID);


        public static void ExportToWord(CatchingAct catchingAct)
        {

        }
    }
}
