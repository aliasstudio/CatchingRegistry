using Equin.ApplicationFramework;
using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry.Views
{
    public partial class CatchingCard : Form
    {
        private CatchingAct catchingAct;

        public CatchingCard(int cardID)
        {
            catchingAct = CatchingCardController.GetByID(cardID);
            InitializeComponent();
            InitializeItems();
        }

        private void InitializeItems()
        {
            catchAnimalsGrid.DataSource = new BindingListView<Animal>(catchingAct.Animals.ToBindingList());

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
            FillMunicipalData();
        }

        private void FillMunicipalData()
        {
/*            var orgID = AuthController.AuthorizedUser.Organization.ID;
            var contractIDs = municipalController.GetAllByOrganizationID(orgID);
            municipalNumCombo.DataSource = contractIDs.Select(contract => $"№{contract.ID}").ToList();*/
        }

        private void FillCatchingActData()
        {
            catchDatePicker.Value = DateTime.Parse(catchingAct.Date);
            catchPurposeBox.Text = catchingAct.CatchingPurpose;
            catchAddressBox.Text = catchingAct.CatchingAddress;
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
            => CatchingCardController.Save(catchingAct);

        private void catchCardFileUploadBtn_Click(object sender, EventArgs e)
        {
            //CatchingCardController.UploadFile(catchingAct, file);
        }
    }
}
