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

            catchAnimalsGrid.DataSource = cardController.GetAnimalSource();
        }

        private void catchAnimalAddBtn_Click(object sender, EventArgs e)
        {
            cardController.AddAnimal(FillAnimalData(new Animal()));
        }

        private void catchAnimalEditBtn_Click(object sender, EventArgs e)
        {
            var itemID = (int)catchAnimalsGrid[0, catchAnimalsGrid.SelectedRows[0].Index].Value;
            var editedAnimal = FillAnimalData(new Animal());
            editedAnimal.ID = itemID;
            cardController.EditAnimal(editedAnimal);
        }

        private void catchAnimalDeleteBtn_Click(object sender, EventArgs e)
        {
            var itemID = (int)catchAnimalsGrid[0, catchAnimalsGrid.SelectedRows[0].Index].Value;
            cardController.DeleteAnimal(itemID);
        }

        private void catchCardSaveBtn_Click(object sender, EventArgs e)
        {

        }

        private Animal FillAnimalData(Animal animal)
        {
            animal.ID = int.Parse(animalCheapNumBox.Text);
            animal.Category = animalCategoryCombo.Text;
            animal.Gender = animalGenderCombo.Text;
            animal.Size = animalSizeBox.Text;
            animal.Features = animalFeaturesBox.Text;

            return animal;
        }

    }
}
