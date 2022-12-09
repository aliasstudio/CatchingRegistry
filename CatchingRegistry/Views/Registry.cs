using CatchingRegistry.Controllers;
using CatchingRegistry.Services;
using CatchingRegistry.Utils;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CatchingRegistry.Views
{
    public partial class Registry : MaterialForm
    {
        private RegistryController registryController;
        private CatchingCardController catchingCardController;
        private AuthController authController;
        private QueryBuilder queryBuilder;
        private Dictionary<string, string> registryFilter;

        public Registry()
        {
            InitializeComponent();
            InitializeControllers();
            InitializeDataGrid();
            InitializeFilter();
            InitializeItems();
            InitializeTheme();
        }

        private void InitializeControllers()
        {
            catchingCardController = CatchingCardController.GetInstance();
            registryController = RegistryController.GetInstance();
            queryBuilder = QueryBuilder.GetInstance();
            authController = AuthController.GetInstance();
        }

        private void InitializeFilter()
        {
            registryFilter = new Dictionary<string, string>();
            foreach (DataGridViewColumn column in registryGrid.Columns)
                if (column.Visible)
                    registryFilter.Add(column.Name, "");
        }

        private void InitializeDataGrid()
        {
            UpdatePage();

            registryPageSizeBox.Value = registryController.PageSize;

            registryGrid.Columns[0].HeaderText = "ID";
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
            if (AuthController.AuthorizedUser != null)
            {
                var role = AuthController.AuthorizedUser.Role;

                if (role.Posibility == 1)
                {
                    registryAddBtn.Visible= false;
                    registryDeleteBtn.Visible= false;
                }

                userRoleLabel.Visible = true;
                userNameLabel.Visible= true;
                userRoleLabel.Text = role.Name;
                userNameLabel.Text = AuthController.AuthorizedUser.Name;
            }
        }

            private void registryOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var itemID = (int)registryGrid[0, registryGrid.SelectedRows[0].Index].Value;
                new CatchingCard(itemID).ShowDialog();
                UpdatePage();
            } 
            catch(Exception ex)
            {
                MessageBox.Show($"Ни одна запись не выделена. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void registryAddBtn_Click(object sender, EventArgs e)
        {
            new CatchingCard().ShowDialog();
            UpdatePage();
        }

        private void registryDeleteBtn_Click(object sender, EventArgs e)
        {
            try 
            { 
                var itemID = (int)registryGrid[0, registryGrid.SelectedRows[0].Index].Value;
                catchingCardController.Delete(itemID);
                UpdatePage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления записи. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageSizeApplyBtn_Click(object sender, EventArgs e)
        {
            registryController.PageSize = registryPageSizeBox.Value;
            UpdatePage();
        }

        private void registryPageSizeBox_ValueChanged(object sender, EventArgs e)
            => registryPageSizeLabel.Text = registryPageSizeBox.Value.ToString();

        public void UpdatePage()
        {
            if (registryFilter != null && registryFilter.Select(x => x.Value != "").Any())
                registryController.Filter = queryBuilder.SelectFrom("CatchingActs").ByCondition(registryFilter).GetResult();
            else
                registryController.Filter = null;
            registryGrid.DataSource = registryController.GetPage();
            registryPageSizeLabel.Text = registryController.PageSize.ToString();
            currentPageBox.Text = $"{registryController.CurrentPage} / {registryController.TotalPages}";
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            registryController.CurrentPage++;
            UpdatePage();
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            registryController.CurrentPage--;
            UpdatePage();
        }

        private void registryGrid_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = registryGrid.Columns[e.ColumnIndex];
            var filterFormResponse = new Filter(registryFilter, column).ShowDialog();
            if (filterFormResponse == DialogResult.OK)
                UpdatePage();
        }

        private void resetFilterBtn_Click(object sender, EventArgs e)
        {
            InitializeFilter();
            UpdatePage();
        }

        private void Registry_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}