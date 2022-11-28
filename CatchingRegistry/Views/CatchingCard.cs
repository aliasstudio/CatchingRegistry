using DocumentFormat.OpenXml.Packaging;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
<<<<<<< Updated upstream
using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;
using CatchingRegistry.Controllers;
using CatchingRegistry.Services;
=======
using MaterialSkin;
using MaterialSkin.Controls;
>>>>>>> Stashed changes

namespace CatchingRegistry.Views
{
    public partial class CatchingCard : MaterialForm
    {
<<<<<<< Updated upstream
        CatchingCardController cardController;
        public CatchingCard(int cardID)
        {
            cardController = new CatchingCardController(cardID);
=======
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
>>>>>>> Stashed changes
            InitializeComponent();
            InitializeItems();
            InitializeTheme();
        }

        private void InitializeTheme()
        {
<<<<<<< Updated upstream
            catchAnimalsGrid.DataSource = cardController.GetAnimalSource();
=======
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
>>>>>>> Stashed changes

            catchAnimalsGrid.Columns[0].HeaderText = "№ чипа";
            catchAnimalsGrid.Columns[0].FillWeight = 12;
            catchAnimalsGrid.Columns[1].HeaderText = "Категория";
            catchAnimalsGrid.Columns[1].FillWeight = 13;
            catchAnimalsGrid.Columns[2].HeaderText = "Пол";
            catchAnimalsGrid.Columns[2].FillWeight = 10;
            catchAnimalsGrid.Columns[3].HeaderText = "Размер";
            catchAnimalsGrid.Columns[3].FillWeight = 15;
<<<<<<< Updated upstream
            catchAnimalsGrid.Columns[4].HeaderText = "Особенности";
            catchAnimalsGrid.Columns[4].FillWeight = 50;
            catchAnimalsGrid.Columns[5].Visible = false;

            FillCatchingActData();
        }

        private void FillMunicipalData()
        {
            var mpContract = cardController.GetMunicipalData();

            //TODO: доделать заполнение комбобокса
=======
            catchAnimalsGrid.Columns[4].HeaderText = "Окрас";
            catchAnimalsGrid.Columns[4].FillWeight = 15;
            catchAnimalsGrid.Columns[5].HeaderText = "Особенности";
            catchAnimalsGrid.Columns[5].FillWeight = 35;
            catchAnimalsGrid.Columns[6].Visible = false;
>>>>>>> Stashed changes
        }

        private void FillCatchingActData()
        {
            var catchingAct = cardController.GetCatchingActData();
            catchDatePicker.Value = DateTime.Parse(catchingAct.Date);
            catchPurposeBox.Text = catchingAct.CatchingPurpose;
            catchAddressBox.Text = catchingAct.CatchingAddress;
        }
        private void FillAnimalData()
        {
            var itemID = (int)catchAnimalsGrid[0, catchAnimalsGrid.SelectedRows[0].Index].Value;
            var animal = cardController.GetAnimalData(itemID);
            animalCheapNumBox.Text = $"{animal.ID}";
            animalCategoryCombo.Text = animal.Category;
            animalGenderCombo.Text = animal.Gender;
            animalSizeBox.Text = animal.Size;
            animalFeaturesBox.Text = animal.Features;
        }

        private Animal CreateAnimal()
        {
            //Странный метод конечно, не знаю как назвать правильнее
            return new Animal()
            {
                ID = int.Parse(animalCheapNumBox.Text),
                Category = animalCategoryCombo.Text,
                Gender = animalGenderCombo.Text,
                Size = animalSizeBox.Text,
                Features = animalFeaturesBox.Text
            };
        }

        private void catchAnimalAddBtn_Click(object sender, EventArgs e)
        {
            cardController.AddAnimal(CreateAnimal());
        }

        private void catchAnimalEditBtn_Click(object sender, EventArgs e)
        {
            var itemID = (int)catchAnimalsGrid[0, catchAnimalsGrid.SelectedRows[0].Index].Value;
            cardController.EditAnimal(itemID, CreateAnimal());
        }

        private void catchAnimalDeleteBtn_Click(object sender, EventArgs e)
        {
            var itemID = (int)catchAnimalsGrid[0, catchAnimalsGrid.SelectedRows[0].Index].Value;
            cardController.DeleteAnimal(itemID);
        }

        private void catchCardSaveBtn_Click(object sender, EventArgs e)
        {
            //TODO: сделать сохранение карточки
            // cardController.Save();
        }

<<<<<<< Updated upstream
        private void catchAnimalsGrid_CellClick(object sender, DataGridViewCellEventArgs e) => FillAnimalData();
=======
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
>>>>>>> Stashed changes
    }
}
