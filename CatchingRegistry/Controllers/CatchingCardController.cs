using CatchingRegistry.Models;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;


namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        private static CatchingCardController instance;
        private static ApplicationContext ctx = new();
        private static List<FileInfo> AttachedFiles = new();

        public static CatchingCardController GetInstance()
        {
            if (instance == null)
                instance = new CatchingCardController();
            ctx = new();

            return instance;
        }

        public CatchingAct? GetByID(int actID) => ctx.CatchingActs.FirstOrDefault(x => x.ID == actID);
        public void Delete(int actID) 
        { 
            ctx.CatchingActs.Remove(GetByID(actID));
            ctx.SaveChanges();
        }

        public void Save(CatchingAct catchingAct)
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

        public List<Animal> GetAnimals(CatchingAct catchingAct)
            => catchingAct.Animals != null ? catchingAct.Animals.ToList() : new List<Animal>();
        public void AddAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals.Add(animal);
        public void EditAnimal(CatchingAct catchingAct, Animal animal) => catchingAct.Animals
            [catchingAct.Animals.IndexOf(
                catchingAct.Animals.FirstOrDefault(x => x.ID == animal.ID)
            )] = animal;
        public void RemoveAnimal(CatchingAct catchingAct, int animalID)
            => catchingAct.Animals.Remove(catchingAct.Animals.FirstOrDefault(x => x.ID == animalID));

        public void AddFile(CatchingAct catchingAct, string filePath)
        {
            var fileName = filePath.Split("\\").Last();
            AttachedFiles.Add(new FileInfo(filePath));
            //Проверка на совпадение файлов
            var programPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            var fileSavePath = @$"{programPath}\Files\Municipal{catchingAct.MunicipalContractID}\Act{catchingAct.ID}";
            if(Directory.Exists(fileSavePath))
            {
                var existFile = Directory.GetFiles(fileSavePath).FirstOrDefault(x => x.Equals(@$"{fileSavePath}\{fileName}"));
                if (existFile == null)
                    catchingAct.Files.Add(new AttachedFile()
                    {
                        Name = fileName,
                        CatchingActID = catchingAct.ID
                    });
            }
        }
        public void RemoveFile(CatchingAct catchingAct, AttachedFile attachedFile)
        {
            var file = AttachedFiles.FirstOrDefault(x => x.Name.Contains(attachedFile.Name));
            if (file != null)
                AttachedFiles.Remove(file);
            //Bug
            ctx.Files.Remove(attachedFile);
            catchingAct.Files.Remove(attachedFile);
        }

        private void UpdateFiles(CatchingAct catchingAct)
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


        public void ExportToWord(CatchingAct catchingAct)
        {

        }
    }
}
