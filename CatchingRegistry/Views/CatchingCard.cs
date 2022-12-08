using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Globalization;
using CatchingRegistry.Services;
using System.Text.RegularExpressions;
using System.Linq;

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
            LoggerService.Add("New Act");

            InitializeComponent();
            InitializeItems();
            InitializeTheme();

        }

        public CatchingCard(int cardID)
        {
            InitializeControllers();
            catchingAct = catchingCardController.GetByID(cardID);
            LoggerService.Add(catchingAct);

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
            InitializeElementsByPermission();
            FillMunicipalCombo();

            if (catchingAct.MunicipalContract != null)
            {
                foreach (var file in catchingCardController.GetAttachedFiles(catchingAct))
                    catchCardFileList.Items.Add(new MaterialListBoxItem(file.Name.Split("\\").Last()));

                FillCatchingActData();
            }
        }

        public void InitializeElementsByPermission()
        {
            if (AuthController.AuthorizedUser.Role.Posibility == 1)
            {
                catchCardSaveBtn.Visible = false;
                catchCardFileUploadBtn.Visible = false;
                catchCardFileDeleteBtn.Visible = false;
                catchAnimalAddBtn.Visible = false;
                catchAnimalEditBtn.Visible = false;
                catchAnimalDeleteBtn.Visible = false;
                materialLabel3.Visible = false;
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
            var municipalContracts = municipalController
                .GetAllByOrganizationID(AuthController.AuthorizedUser.Organization.ID)
                .Select(contract => $"№{contract.ID}")
                .ToList();

            municipalNumCombo.DataSource = municipalContracts.Count == 0
                ? new List<string> { $"№{catchingAct.MunicipalContractID}" }
                : municipalContracts;
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

        private bool AreFieldsEmpty(Dictionary<string, string> keyValuePairs)
        {
            var spaceRegex = new Regex(@"\S+");

            foreach (var item in keyValuePairs)
                if (!spaceRegex.IsMatch(item.Value))
                {
                    MessageBox.Show($"Поле '{item.Key}' не заполнено.");
                    return true;
                }

            return false;
        }

        private bool IsAnimalDataCorrect()
        {
            var keyValuePairs = new Dictionary<string, string>
            {
                { "Номер чипа", animalCheapNumBox.Text },
                { "Категория", animalCategoryCombo.Text },
                { "Пол", animalGenderCombo.Text },
                { "Размер", animalSizeBox.Text },
                { "Окрас", animalСolorBox.Text },
                { "Особенности", animalFeaturesBox.Text }
            };

            // Проверка на пустые поля
            if (AreFieldsEmpty(keyValuePairs))
                return false;

            // Проверка на корректность указаного номера животного
            var numRegex = new Regex(@"\D");
            if (numRegex.IsMatch(animalCheapNumBox.Text))
            {
                MessageBox.Show($"Номер животного - число.");
                return false;
            }

            // Проверка на существование животного с таким номером.
            var isAnimalNumExist = catchingCardController
                .GetAllAnimals()
                .Any(x => x.ID == int.Parse(animalCheapNumBox.Text));
            if (isAnimalNumExist)
            {
                MessageBox.Show("Животное с таким номером уже существует.");
                return false;
            }

            return true;
        }

        private Animal CreateAnimalFromData()
        {
            var animal = new Animal();

            animal.ID = int.Parse(animalCheapNumBox.Text);
            animal.Category = animalCategoryCombo.Text;
            animal.Gender = animalGenderCombo.Text;
            animal.Size = animalSizeBox.Text;
            animal.Color = animalСolorBox.Text;
            animal.Features = animalFeaturesBox.Text;
          
            return animal;
        }

        private void catchAnimalAddBtn_Click(object sender, EventArgs e)
        {
            if (!IsAnimalDataCorrect())
                return;

            var animal = CreateAnimalFromData();
            catchingCardController.AddAnimal(catchingAct, animal);
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

        private bool IsActDataCorrect()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { "Муниципальный контракт", municipalNumCombo.Text },
                { "Адрес отлова", catchAddressBox.Text },
                { "Цель отлова", catchPurposeBox.Text }
            };

            if (AreFieldsEmpty(keyValuePairs))
                return false;

            return true;
        }

        private void catchCardSaveBtn_Click(object sender, EventArgs e)
        {
            if (!IsActDataCorrect())
                return; 

            catchingAct.MunicipalContractID = int.Parse(municipalNumCombo.Text.Substring(1));
            catchingAct.CatchingPurpose = catchPurposeBox.Text;
            catchingAct.CatchingAddress = catchAddressBox.Text;
            catchingAct.Date = catchDatePicker.Value.ToString("dd.MM.yyyy");
            catchingCardController.Save(catchingAct);
            MessageBox.Show("Акт успешно сохранен");
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

        private void catchCardExportBtn_Click(object sender, EventArgs e)
        {
            if (catchingAct.ID == null)
            {
                MessageBox.Show("Сохраните акт отлова перед экспортом в ворд");
                return;
            }
            catchingCardController.ExportToWord(catchingAct);
        }

        private void CatchingCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoggerService.Add("CatchingCardClosed");
        }

        private void catchCardFileList_DoubleClick(object sender, EventArgs e)
        {
            var fileIndex = catchCardFileList.SelectedIndex;
            var fileName = catchCardFileList.Items[fileIndex].Text;
            catchingCardController.OpenFile(catchingAct, fileName);
        }
    }
}
