using CatchingRegistry.Models;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using CatchingRegistry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Controllers
{
    public class CardController
    {
        private Form formInstance;
        private Context context;
        public CardController(Form formInstance)
        {
            this.formInstance = formInstance;
            this.context = new Context();
        }

        public void AddAnimals(IEnumerable<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                context.Animals.Add(animal);
                context.SaveChanges();
            }
        }

        public void ExportToWord(Dictionary<string, string> dictionary, List<Animal> animals) 
        {
            string path = @$"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\template.docx";

            Word.Application wordApp = new Word.Application();

            Word.Document document = wordApp.Documents.OpenNoRepairDialog(path, ReadOnly: true);

            ReplaceWordStub(document, dictionary);

            Word.Table table = document.Tables[1];
            var rowsCount = table.Rows.Count;
            var columnsCount = table.Columns.Count;




            // Добавление животных в таблицу
            for (int i = 0; i < animals.Count; i++)
            {
                // Добавление строки
                object oMissing = Missing.Value;
                table.Rows.Add(oMissing);

                table.Cell(i+2, 1).Range.Text = animals[i].Id;
                table.Cell(i+2, 2).Range.Text = animals[i].Category;
                table.Cell(i+2, 3).Range.Text = animals[i].Gender;
                table.Cell(i+2, 4).Range.Text = animals[i].Size;
                table.Cell(i+2, 5).Range.Text = animals[i].Features;
            }



            string path2 = @$"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\docs\result.docx";
            document.SaveAs2(FileName: path2);

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
    }
}
