using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CatchingRegistry.Views
{
    public partial class CatchingCard : MaterialForm
    {
        private CatchingCardController catchingCardController;
        private MunicipalController municipalController;
        private CatchingAct catchingAct;

        public CatchingCard()
        {
            InitializeControllers();
            catchingAct = new();

            InitializeComponent();
            InitializeItems();
            InitializeTheme();
        }

        public CatchingCard(int cardID)
        {
            InitializeControllers();
            catchingAct = catchingCardController.GetByID(cardID);

            InitializeComponent();
            InitializeItems();
            InitializeTheme();
        }
        private void InitializeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void InitializeItems()
        {
            InitializeDataGrid();
            FillMunicipalCombo();

            if (catchingAct.MunicipalContract != null)
            {
                foreach (var file in catchingAct.Files)
                    catchCardFileList.Items.Add(new MaterialListBoxItem(file.Name.Split("\\").Last()));

                FillCatchingActData();
            }
        }

        private void InitializeControllers()
        {
            catchingCardController = CatchingCardController.GetInstance();
            municipalController = MunicipalController.GetInstance();
        }

        private void InitializeDataGrid()
        {
            catchAnimalsGrid.DataSource = catchingCardController.GetAnimals(catchingAct);

            catchAnimalsGrid.Columns[0].HeaderText = "№ чипа";
            catchAnimalsGrid.Columns[0].FillWeight = 12;
            catchAnimalsGrid.Columns[1].HeaderText = "Категория";
            catchAnimalsGrid.Columns[1].FillWeight = 13;
            catchAnimalsGrid.Columns[2].HeaderText = "Пол";
            catchAnimalsGrid.Columns[2].FillWeight = 10;
            catchAnimalsGrid.Columns[3].HeaderText = "Размер";
            catchAnimalsGrid.Columns[3].FillWeight = 15;
            catchAnimalsGrid.Columns[4].HeaderText = "Окрас";
            catchAnimalsGrid.Columns[4].FillWeight = 15;
            catchAnimalsGrid.Columns[5].HeaderText = "Особенности";
            catchAnimalsGrid.Columns[5].FillWeight = 35;
            catchAnimalsGrid.Columns[6].Visible = false;
        }

        private void FillCatchingActData()
        {
            catchDatePicker.Value = DateTime.Parse(catchingAct.Date);
            catchPurposeBox.Text = catchingAct.CatchingPurpose;
            catchCityBox.Text = catchingAct.CatchingAddress.Split("&")[0];
            catchAddressBox.Text = catchingAct.CatchingAddress.Split("&")[1];
        }

        private void FillMunicipalCombo()
        {
            municipalNumCombo.DataSource = municipalController
                .GetAllByOrganizationID(AuthController.AuthorizedUser.Organization.ID)
                .Select(contract => $"№{contract.ID}")
                .ToList();
        }

        private string? GetAnimalValueAtIndex(int index)
            => catchAnimalsGrid[index, catchAnimalsGrid.SelectedRows[0].Index].Value == null
               ? ""
               : catchAnimalsGrid[index, catchAnimalsGrid.SelectedRows[0].Index].Value.ToString();

        private void FillAnimalData()
        {
            animalCheapNumBox.Text = GetAnimalValueAtIndex(0);
            animalCategoryCombo.Text = GetAnimalValueAtIndex(1);
            animalGenderCombo.Text = GetAnimalValueAtIndex(2);
            animalSizeBox.Text = GetAnimalValueAtIndex(3);
            animalСolorBox.Text = GetAnimalValueAtIndex(4);
            animalFeaturesBox.Text = GetAnimalValueAtIndex(5);
        }

        private Animal CreateAnimalFromData() => new()
        {
            ID = int.Parse(animalCheapNumBox.Text),
            Category = animalCategoryCombo.Text,
            Gender = animalGenderCombo.Text,
            Size = animalSizeBox.Text,
            Color = animalСolorBox.Text,
            Features = animalFeaturesBox.Text
        };

        private void catchAnimalAddBtn_Click(object sender, EventArgs e)
        {
            catchingCardController.AddAnimal(catchingAct, CreateAnimalFromData());
            catchAnimalsGrid.DataSource = catchingCardController.GetAnimals(catchingAct);
        }
        private void catchAnimalEditBtn_Click(object sender, EventArgs e)
        {
            catchingCardController.EditAnimal(catchingAct, CreateAnimalFromData());
            catchAnimalsGrid.DataSource = catchingCardController.GetAnimals(catchingAct);
        }

        private void catchAnimalDeleteBtn_Click(object sender, EventArgs e)
        {
            catchingCardController.RemoveAnimal(catchingAct, CreateAnimalFromData());
            catchAnimalsGrid.DataSource = catchingCardController.GetAnimals(catchingAct);
        }

        private void catchCardSaveBtn_Click(object sender, EventArgs e)
            => catchingCardController.Save(catchingAct);

        private void catchAnimalsGrid_CellClick(object sender, DataGridViewCellEventArgs e) 
            => FillAnimalData();

        private void catchCardExportBtn_Click(object sender, EventArgs e)
        {
            var contractDate = DateTime.Parse(catchingAct.MunicipalContract.ContractDate);
            var catchingActDate = DateTime.Parse(catchingAct.Date);

            var dictionary = new Dictionary<string, string>
            {
                {
                    "{actNumber}",
                    catchingAct.ID.ToString()
                },
                {
                    "{locality}",
                    catchingAct.CatchingAddress.Split("&")[0].ToString()
                },
                {
                    "{catchingActAddress}",
                    catchingAct.CatchingAddress.Split("&")[1].ToString()
                },
                {
                    "{catchingActDate}",
                    catchingActDate.Day.ToString()
                },
                {
                    "{catchingActMonth}",
                    catchingActDate.Month.ToString()
                },
                {
                    "{catchingActYear}",
                    catchingActDate.Year.ToString()
                },
                {
                    "{organisationName}",
                    AuthController.AuthorizedUser.Organization.Name.ToString()
                },
                {
                    "{contractNumber}",
                    catchingAct.MunicipalContract.ID.ToString()
                },
                {
                    "{contractDate}",
                    contractDate.Day.ToString()
                },
                {
                    "{contractMonth}",
                    contractDate.Month.ToString()
                },
                {
                    "{contractYear}",
                    contractDate.Year.ToString()
                },
                {
                    "{municipalName}",
                    catchingAct.MunicipalContract.MunicipalName.ToString()
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
                // Добавление строки
                object oMissing = Missing.Value;
                table.Rows.Add(oMissing);

                table.Cell(i + 2, 1).Range.Text = $"{i+1}";
                table.Cell(i + 2, 2).Range.Text = catchingAct.Animals[i].Category;
                table.Cell(i + 2, 3).Range.Text = catchingAct.Animals[i].Gender;
                table.Cell(i + 2, 4).Range.Text = catchingAct.Animals[i].Size;

                table.Cell(i + 2, 6).Range.Text = catchingAct.Animals[i].Features;
                table.Cell(i + 2, 7).Range.Text = catchingAct.Animals[i].ID.ToString();
            }


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
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var file = catchingAct.Files.FirstOrDefault(x => x.Name == openFileDialog.SafeFileName);
            catchingCardController.AddFile(catchingAct, openFileDialog.FileName);
            if (file == null)
                catchCardFileList.Items.Add(new MaterialListBoxItem(openFileDialog.SafeFileName));
        }

        private void catchCardFileDeleteBtn_Click(object sender, EventArgs e)
        {
            var fileName = catchCardFileList.Items[catchCardFileList.SelectedIndex].ToString().Split("\\").Last();
            var file = catchingAct.Files.FirstOrDefault(x => x.Name == fileName);
            catchingCardController.RemoveFile(catchingAct, file);
            catchCardFileList.Items.RemoveAt(catchCardFileList.SelectedIndex);
        }
    }
}
