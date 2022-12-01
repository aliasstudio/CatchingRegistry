using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Globalization;

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
            catchingAct.Animals = new List<Animal>();
            catchingAct.Files = new List<AttachedFile>();

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
            Text = $"Акт отлова №{catchingAct.ID}";
            catchDatePicker.Value = DateTime.Parse(catchingAct.Date);
            catchPurposeBox.Text = catchingAct.CatchingPurpose;
            catchAddressBox.Text = catchingAct.CatchingAddress;
            municipalNumCombo.Text = $"№{catchingAct.MunicipalContractID}";
            catchAnimalsCountLabel.Text = catchingAct.Animals.Count().ToString();
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
            Features = animalFeaturesBox.Text,
        };

        private void catchAnimalAddBtn_Click(object sender, EventArgs e)
        {
            catchingCardController.AddAnimal(catchingAct, CreateAnimalFromData());
            catchAnimalsGrid.DataSource = catchingCardController.GetAnimals(catchingAct);
            catchAnimalsCountLabel.Text = catchingAct.Animals.Count().ToString();
        }
        private void catchAnimalEditBtn_Click(object sender, EventArgs e)
        {
            catchingCardController.EditAnimal(catchingAct, CreateAnimalFromData());
            catchAnimalsGrid.DataSource = catchingCardController.GetAnimals(catchingAct);
        }

        private void catchAnimalDeleteBtn_Click(object sender, EventArgs e)
        {
            catchingCardController.RemoveAnimal(catchingAct, int.Parse(GetAnimalValueAtIndex(0)));
            catchAnimalsGrid.DataSource = catchingCardController.GetAnimals(catchingAct);
            catchAnimalsCountLabel.Text = catchingAct.Animals.Count().ToString();
        }

        private void catchCardSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                catchingAct.MunicipalContractID = int.Parse(municipalNumCombo.Text.Substring(1));
                catchingAct.CatchingPurpose = catchPurposeBox.Text;
                catchingAct.CatchingAddress = catchAddressBox.Text;
                catchingAct.Date = catchDatePicker.Value.ToString("dd.MM.yyyy");
                catchingCardController.Save(catchingAct);
                MessageBox.Show("Акт успешно сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void catchAnimalsGrid_CellClick(object sender, DataGridViewCellEventArgs e) 
            => FillAnimalData();

        

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
            var fileName = catchCardFileList.Items[catchCardFileList.SelectedIndex].Text.Split("\\").Last();
            var file = catchingAct.Files.FirstOrDefault(x => x.Name == fileName);
            catchingCardController.RemoveFile(catchingAct, file);
            catchCardFileList.Items.RemoveAt(catchCardFileList.SelectedIndex);
        }

        private void catchCardExportBtn_Click_1(object sender, EventArgs e)
        {
            catchingCardController.ExportToWord(catchingAct);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            catchingCardController.Save(catchingAct);
        }
    }
}
