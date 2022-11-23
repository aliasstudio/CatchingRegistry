using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using CatchingRegistry.Services;

namespace CatchingRegistry.Views
{
    public partial class Registry : Form
    {
        RegistryController registryController = new();
        public Registry()
        {
            InitializeComponent();
            InitializeItems();
        }

        private void registryOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var itemID = (int)registryGrid[0, registryGrid.SelectedRows[0].Index].Value;
                new CatchingCard(itemID).Show();
            } 
            catch(Exception ex)
            {
                MessageBox.Show($"Ни одна запись не выделена. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void registryAddBtn_Click(object sender, EventArgs e)
        {
            new CatchingCard(-1).Show();
        }

        private void registryDeleteBtn_Click(object sender, EventArgs e)
        {
            try { 
                var itemID = (int)registryGrid[0, registryGrid.SelectedRows[0].Index].Value;
                registryController.Delete(itemID);
                UpdateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ни одна запись не выделена. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeItems()
        {
            UpdateGrid();

            registryGrid.Columns[0].HeaderText = "№";
            registryGrid.Columns[0].FillWeight = 8;
            registryGrid.Columns[1].HeaderText = "Дата";
            registryGrid.Columns[1].FillWeight = 12;
            registryGrid.Columns[2].HeaderText = "№ МК";
            registryGrid.Columns[2].FillWeight = 15;
            registryGrid.Columns[3].HeaderText = "Причина отлова";
            registryGrid.Columns[3].FillWeight = 30;
            registryGrid.Columns[4].HeaderText = "Адрес отлова";
            registryGrid.Columns[4].FillWeight = 35;
            registryGrid.Columns[5].Visible = false;

            registryPageSizeBox.Text = "5";
        }
        private void Registry_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            registryController.CurrentPage++;
            UpdateGrid();
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            registryController.CurrentPage--;
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            registryGrid.DataSource = registryController.GetPage();
            currentPageBox.Text = $"{registryController.CurrentPage} / {registryController.TotalPages}";
        }

        private void registryPageSizeBox_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(registryPageSizeBox.Text, out int pageSize))
            {
                registryController.PageSize = pageSize;
                UpdateGrid();
            }
        }
    }
}