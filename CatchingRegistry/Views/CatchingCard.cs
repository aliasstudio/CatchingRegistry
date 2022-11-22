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
using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;
using CatchingRegistry.Controllers;
using CatchingRegistry.Services;

namespace CatchingRegistry.Views
{
    public partial class CatchingCard : Form
    {
        CatchingCardController cardController;
        public CatchingCard(int cardID)
        {
            cardController = new CatchingCardController(cardID);
            InitializeComponent();
            InitializeItems();
        }

        private void InitializeItems()
        {
            catchAnimalsGrid.DataSource = cardController.GetAnimalSource();

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

            FillCatchingActData();
        }

        private void FillMunicipalData()
        {
            var mpContract = cardController.GetMunicipalData();

            //TODO: доделать заполнение комбобокса
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

        private void catchAnimalsGrid_CellClick(object sender, DataGridViewCellEventArgs e) => FillAnimalData();
    }
}
