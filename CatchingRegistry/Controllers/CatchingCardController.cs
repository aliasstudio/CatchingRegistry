using CatchingRegistry.Models;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;


namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        private static CatchingCardController instance;
        static ApplicationContext ctx = new();
        static List<FileInfo> AttachedFiles = new();

        public static CatchingCardController GetInstance()
        {
            if (instance == null)
                instance = new CatchingCardController();
            ctx = new();

            return instance;
        }

        public static CatchingAct? GetByID(int actID) => ctx.CatchingActs.Find(actID);
        public static void Delete(int actID) => ctx.CatchingActs.Remove(GetByID(actID));

        public static void Save(CatchingAct catchingAct)
        {
            if (ctx.CatchingActs.Contains(catchingAct))
                ctx.CatchingActs.Update(catchingAct);
            else
                ctx.CatchingActs.Add(catchingAct);
            try
            {
                ctx.SaveChanges();
                UpdateFiles(catchingAct);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сохранения акта. {ex}");
            }
        }


        public static void AddAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals.Add(animal);
        public static void EditAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals
            [catchingAct.Animals.IndexOf(
                catchingAct.Animals.FirstOrDefault(x => x.ID == animal.ID)
            )] = animal;
        public static void RemoveAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals.Remove(animal);

        public static void AddFile(CatchingAct catchingAct, string filePath)
        {
            var fileName = filePath.Split("\\").Last();
            AttachedFiles.Add(new FileInfo(filePath));
            catchingAct.Files.Add(new AttachedFile()
            {
                Name = fileName,
                CatchingActID = catchingAct.ID
            });
        }
        public static void RemoveFile(CatchingAct catchingAct, AttachedFile attachedFile)
        {
            var file = AttachedFiles.FirstOrDefault(x => x.Name.Contains(attachedFile.Name));
            if (file != null)
                AttachedFiles.Remove(file);

            catchingAct.Files.Remove(attachedFile);
            ctx.Files.Remove(attachedFile);
        }

        private static void UpdateFiles(CatchingAct catchingAct)
        {
            var programPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            var fileSavePath = @$"{programPath}\Files\Municipal{catchingAct.MunicipalContractID}\Act{catchingAct.ID}";

            Directory.CreateDirectory(fileSavePath);
            //Загрузка прикрепленных файлов
            foreach(var file in AttachedFiles)
            {
                var fileName = file.Name.Split("\\").Last();
                file.CopyTo(@$"{fileSavePath}\{fileName}", true);
            }
            //Проверка на лишние файлы после редактирования
            var localFiles = Directory.GetFiles(fileSavePath);
            if (localFiles.Count() > 0)
                foreach (var file in Directory.GetFiles(fileSavePath))
                {
                    var fileName = file.Split("\\").Last();
                    if (catchingAct.Files.FirstOrDefault(x => x.Name == fileName) == null)
                        File.Delete(file);
                }
            else
                Directory.Delete(fileSavePath);
        }


        public static void ExportToWord(CatchingAct catchingAct)
        {

        }
    }
}
