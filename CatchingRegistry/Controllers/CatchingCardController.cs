using CatchingRegistry.Models;
using CatchingRegistry.Services;
using System.Diagnostics;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;


namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        private static CatchingCardController instance;
        private CatchingCardService catchingCardService;
        private static List<FileInfo> AttachedFiles = new();

        public static CatchingCardController GetInstance()
        {
            if (instance == null)
                instance = new CatchingCardController();

            return instance;
        }

        public CatchingCardController()
        {
            catchingCardService = CatchingCardService.GetInstance();
        }

        public CatchingAct? GetByID(int actID) => catchingCardService.GetByID(actID);
        public void Delete(int actID) 
        {
            catchingCardService.Delete(actID);
            LoggerService.Add($"ID: {actID}");
        }

        public void Save(CatchingAct catchingAct)
        {
            catchingCardService.Save(catchingAct);
            UpdateFiles(catchingAct);
            LoggerService.Add(catchingAct);
        }
        
        public List<Animal> GetAllAnimals()
            => catchingCardService.GetAllAnimals();
        public List<Animal> GetAnimals(CatchingAct catchingAct)
            => catchingAct.Animals != null 
            ? catchingAct.Animals.ToList() 
            : new List<Animal>();
        public void AddAnimal(CatchingAct catchingAct, Animal animal) 
        {
            catchingAct.Animals.Add(animal);
            LoggerService.Add(animal);
        }
        public void EditAnimal(CatchingAct catchingAct, Animal animal)
        {
            catchingAct.Animals[catchingAct.Animals.IndexOf(
                catchingAct.Animals.Single(x => x.ID == animal.ID)
            )] = animal;
            LoggerService.Add(animal);
        }
        public void RemoveAnimal(CatchingAct catchingAct, int animalID)
        {
            catchingAct.Animals.Remove(catchingAct.Animals.FirstOrDefault(x => x.ID == animalID));
            LoggerService.Add($"ID: {animalID}");
        }

        public List<AttachedFile> GetAttachedFiles(CatchingAct catchingAct)
            => catchingCardService.GetAttachedFiles(catchingAct);
        public void AddFile(CatchingAct catchingAct, string filePath)
        {
            var fileName = filePath.Split("\\").Last();
            AttachedFiles.Add(new FileInfo(filePath));
            //???????????????? ???? ???????????????????? ????????????
            var programPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            var fileSavePath = @$"{programPath}\Files\Municipal{catchingAct.MunicipalContractID}\Act{catchingAct.ID}";
            if (!File.Exists(@$"{fileSavePath}\{fileName}"))
                catchingCardService.AddFile(catchingAct, fileName);
            LoggerService.Add(filePath);
        }
        public void RemoveFile(CatchingAct catchingAct, AttachedFile attachedFile)
        {
            var file = AttachedFiles.FirstOrDefault(x => x.Name.Contains(attachedFile.Name));
            if (file != null)
                AttachedFiles.Remove(file);
            catchingAct.Files.Remove(attachedFile);
            LoggerService.Add(attachedFile);
        }
        private void UpdateFiles(CatchingAct catchingAct)
        {
            var programPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            var fileSavePath = @$"{programPath}\Files\Municipal{catchingAct.MunicipalContractID}\Act{catchingAct.ID}";

            Directory.CreateDirectory(fileSavePath);
            //???????????????? ?????????????????????????? ????????????
            foreach(var file in AttachedFiles)
            {
                var fileName = file.Name.Split("\\").Last();
                file.CopyTo(@$"{fileSavePath}\{fileName}", true);
            }
            //???????????????? ???? ???????????? ?????????? ?????????? ????????????????????????????
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

        public void ExportToWord(CatchingAct catchingAct, string path)
        {
            var contractDate = DateTime.Parse(catchingAct.MunicipalContract.ContractDate)
                .ToString("dd MMMM yyyy")
                .Split(" ");
            var catchingActDate = DateTime.Parse(catchingAct.Date)
                .ToString("dd MMMM yyyy")
                .Split(" ");

            var dictionary = new Dictionary<string, string>
            {
                { "{actNumber}", catchingAct.ID.ToString() },
                { "{locality}", catchingAct.MunicipalContract.Municipality },
                { "{catchingActAddress}", catchingAct.CatchingAddress },
                { "{catchingActDate}", catchingActDate[0].ToString() },
                { "{catchingActMonth}", catchingActDate[1].ToString() },
                { "{catchingActYear}", catchingActDate[2].ToString() },
                { "{organisationName}", AuthController.AuthorizedUser.Organization.Name.ToString() },
                { "{contractNumber}", catchingAct.MunicipalContract.ID.ToString() },
                { "{contractDate}", contractDate[0].ToString() },
                { "{contractMonth}", contractDate[1].ToString() },
                { "{contractYear}", contractDate[2].ToString() },
            };
            string templatePath = @$"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\template.docx";

            Word.Application wordApp = new Word.Application();
            Word.Document document = wordApp.Documents.OpenNoRepairDialog(templatePath, ReadOnly: true);

            ReplaceWordStub(document, dictionary);

            Word.Table table = document.Tables[1];
            var rowsCount = table.Rows.Count;
            var columnsCount = table.Columns.Count;

            // ???????????????????? ???????????????? ?? ??????????????
            for (int i = 0; i < catchingAct.Animals.Count; i++)
            {
                // ???????????????????? ????????????
                object oMissing = Missing.Value;
                table.Rows.Add(oMissing);

                table.Cell(i + 2, 1).Range.Text = $"{i + 1}";
                table.Cell(i + 2, 2).Range.Text = catchingAct.Animals[i].Category;
                table.Cell(i + 2, 3).Range.Text = catchingAct.Animals[i].Gender;
                table.Cell(i + 2, 4).Range.Text = catchingAct.Animals[i].Size;
                table.Cell(i + 2, 5).Range.Text = catchingAct.Animals[i].Color;
                table.Cell(i + 2, 6).Range.Text = catchingAct.Animals[i].Features;
                table.Cell(i + 2, 7).Range.Text = catchingAct.Animals[i].ID.ToString();
            }

            document.SaveAs2(FileName: path);
            document.Close();
            wordApp.Quit();
        }

        private void ReplaceWordStub(Word.Document wordDocument, Dictionary<string, string> dictionary)
        {
            foreach (var record in dictionary)
            {
                var range = wordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: record.Key, ReplaceWith: record.Value);
            }
        }

        public void OpenFile(CatchingAct catchingAct, string fileName)
        {
            var programPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            var filePath = @$"{programPath}\Files\Municipal{catchingAct.MunicipalContractID}\Act{catchingAct.ID}";

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.UseShellExecute = true;
            processInfo.FileName = @$"{filePath}\{fileName}";

            if (!File.Exists(@$"{filePath}\{fileName}"))
            {
                MessageBox.Show("??????????????????, ???????????? ?????? ?????????????? ????????.");
                return;
            }


            Process.Start(processInfo);
        }
    }
}