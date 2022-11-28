using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace CatchingRegistry.Views
{
    public partial class CatchingCard : Form
    {
        private CatchingCardController catchingCardController;
        private MunicipalController municipalController;
        private CatchingAct catchingAct;

        public CatchingCard()
        {
            catchingAct = new();
            InitializeComponent();
            InitializeItems();
        }

        public CatchingCard(int cardID)
        {
            catchingAct = CatchingCardController.GetByID(cardID);
            InitializeComponent();
            InitializeItems();
        }

        private void InitializeItems()
        {
            catchingCardController = CatchingCardController.GetInstance();
            municipalController = MunicipalController.GetInstance();

            InitializeDataGrid();

            if (catchingAct.MunicipalContract != null)
            {
                foreach (var file in catchingAct.Files)
                    catchCardFileList.Items.Add(file.Name.Split("\\").Last());

                FillCatchingActData();
                FillMunicipalCombo();
            }
        }

        private void InitializeDataGrid()
        {
            catchAnimalsGrid.DataSource = catchingAct.Animals == null ? new List<Animal>() : catchingAct.Animals;

            catchAnimalsGrid.Columns[0].HeaderText = "№ чипа";
            catchAnimalsGrid.Columns[0].FillWeight = 12;
            catchAnimalsGrid.Columns[1].HeaderText = "Категория";
            catchAnimalsGrid.Columns[1].FillWeight = 13;
            catchAnimalsGrid.Columns[2].HeaderText = "Пол";
            catchAnimalsGrid.Columns[2].FillWeight = 10;
            catchAnimalsGrid.Columns[3].HeaderText = "Размер";
            catchAnimalsGrid.Columns[3].FillWeight = 15;
            catchAnimalsGrid.Columns[4].HeaderText = "Особенности";
            catchAnimalsGrid.Columns[4].FillWeight = 50;
            catchAnimalsGrid.Columns[5].Visible = false;
        }

        private void FillCatchingActData()
        {
            catchDatePicker.Value = DateTime.Parse(catchingAct.Date);
            catchPurposeBox.Text = catchingAct.CatchingPurpose;
            catchAddressBox.Text = catchingAct.CatchingAddress;
        }

        private void FillMunicipalCombo()
        {
            municipalNumCombo.DataSource = municipalController
                .GetAllByOrganizationID(AuthController.AuthorizedUser.Organization.ID)
                .Select(contract => $"№{contract.ID}")
                .ToList();
        }

        private string GetAnimalValueAtIndex(int index)
            => catchAnimalsGrid[index, catchAnimalsGrid.SelectedRows[0].Index].Value.ToString();

        private void FillAnimalData()
        {
            animalCheapNumBox.Text = GetAnimalValueAtIndex(0);
            animalCategoryCombo.Text = GetAnimalValueAtIndex(1);
            animalGenderCombo.Text = GetAnimalValueAtIndex(2);
            animalSizeBox.Text = GetAnimalValueAtIndex(3);
            animalFeaturesBox.Text = GetAnimalValueAtIndex(4);
        }

        private Animal CreateAnimalFromData() => new()
        {
            ID = int.Parse(animalCheapNumBox.Text),
            Category = animalCategoryCombo.Text,
            Gender = animalGenderCombo.Text,
            Size = animalSizeBox.Text,
            Features = animalFeaturesBox.Text
        };

        private void catchAnimalAddBtn_Click(object sender, EventArgs e)
            => CatchingCardController.AddAnimal(catchingAct, CreateAnimalFromData());
        private void catchAnimalEditBtn_Click(object sender, EventArgs e)
            => CatchingCardController.EditAnimal(catchingAct, CreateAnimalFromData());

        private void catchAnimalDeleteBtn_Click(object sender, EventArgs e)
            => CatchingCardController.RemoveAnimal(catchingAct, CreateAnimalFromData());

        private void catchCardSaveBtn_Click(object sender, EventArgs e)
            => CatchingCardController.Save(catchingAct);

        private void catchAnimalsGrid_CellClick(object sender, DataGridViewCellEventArgs e) 
            => FillAnimalData();

        private void catchCardExportBtn_Click(object sender, EventArgs e)
        {
            var dictionary = new Dictionary<string, string>
            {
                {
                    "{actNumber}",
                    "12"
                },
                {
                    "{locality}",
                    "City"
                },
                {
                    "{catchingActDate}",
                    "Custom2313"
                }
            };


            string path = @$"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\template.docx";

            Word.Application wordApp = new Word.Application();

            Word.Document document = wordApp.Documents.OpenNoRepairDialog(path, ReadOnly: true);

            ReplaceWordStub(document, dictionary);

            Word.Table table = document.Tables[1];
            var rowsCount = table.Rows.Count;
            var columnsCount = table.Columns.Count;

            // Добавление животных в таблицу
            for (int i = 0; i < catchingAct.Animals.Count; i++)
            {
                table.Cell(i, 0).Range.Text = catchingAct.Animals[i].ID.ToString();
                table.Cell(i, 1).Range.Text = catchingAct.Animals[i].Category;
                table.Cell(i, 2).Range.Text = catchingAct.Animals[i].Gender;
                table.Cell(i, 3).Range.Text = catchingAct.Animals[i].Size;
                table.Cell(i, 4).Range.Text = catchingAct.Animals[i].Features;
            }

            // Добавление строки
            object oMissing = Missing.Value;
            table.Rows.Add(oMissing);

            document.SaveAs2(FileName: @$"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName}\Docs\result.docx");

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

        private void catchCardFileUploadBtn_Click(object sender, EventArgs e)
        {
            //
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var file = catchingAct.Files.FirstOrDefault(x => x.Name == openFileDialog.SafeFileName);
            CatchingCardController.AddFile(catchingAct, openFileDialog.FileName);
            if (file == null)
                catchCardFileList.Items.Add(openFileDialog.SafeFileName);
        }

        private void catchCardFileDeleteBtn_Click(object sender, EventArgs e)
        {
            var fileName = catchCardFileList.Items[catchCardFileList.SelectedIndex].ToString().Split("\\").Last();
            var file = catchingAct.Files.FirstOrDefault(x => x.Name == fileName);
            CatchingCardController.RemoveFile(catchingAct, file);
            catchCardFileList.Items.RemoveAt(catchCardFileList.SelectedIndex);
        }

        private void CatchingCard_FormClosed(object sender, FormClosedEventArgs e)
        {
/*            if (catchingAct.MunicipalContract != null)
                catchingAct.Files.RemoveAll(file => file.Path.Split(@"\").Length > 1);*/
        }
    }
}
