using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Text;

namespace CatchingRegistry.Views
{
    public partial class Registry : MaterialForm
    {
        private RegistryController registryController;
        private CatchingCardController catchingCardController;
        private Dictionary<string, string> registryFilter;
        private QueryBuilder queryBuilder;
        private List<CatchingAct> records;
        private int currentPage = 1;
        public int CurrentPage
        {
            get => currentPage;
            set
            {
                if (value > 0 && value <= totalPages)
                    currentPage = value;
            }
        }
        private int totalPages = 1;
        public int PageSize { get; set; } = 10;


        public Registry()
        {
            InitializeComponent();
            InitializeControllers();
            InitializeDataGrid();
            InitializeTheme();
            InitializeFilter();

            registryPageSizeBox.Value = 10;
            totalPages = (int)Math.Ceiling((double)records.Count() / PageSize);
            currentPageBox.Text = $"{CurrentPage} / {totalPages}";
            queryBuilder = QueryBuilder.GetInstance();
        }


        private void InitializeFilter()
        {
            registryFilter = new Dictionary<string, string>();
            foreach (DataGridViewColumn column in registryGrid.Columns)
                if (column.Visible)
                    registryFilter.Add(column.Name, "");
        }

        private void InitializeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void registryOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var itemID = (int)registryGrid[0, registryGrid.SelectedRows[0].Index].Value;
                new CatchingCard(itemID).ShowDialog();
                records = registryController.GetPage();
                UpdateNavigationItems();
            } 
            catch(Exception ex)
            {
                MessageBox.Show($"Ни одна запись не выделена. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void registryAddBtn_Click(object sender, EventArgs e)
        {
            new CatchingCard().ShowDialog();
            records = registryController.GetPage();
            UpdateNavigationItems();
        }

        private void registryDeleteBtn_Click(object sender, EventArgs e)
        {
            try 
            { 
                var itemID = (int)registryGrid[0, registryGrid.SelectedRows[0].Index].Value;
                catchingCardController.Delete(itemID);
                records = registryController.GetPage();
                UpdateNavigationItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления записи. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageSizeApplyBtn_Click(object sender, EventArgs e)
        {
            PageSize = registryPageSizeBox.Value;
            CurrentPage = 1;
            UpdateNavigationItems();
        }

        private void registryPageSizeBox_ValueChanged(object sender, EventArgs e)
        {
            pageSliderLabel.Text = registryPageSizeBox.Value.ToString();
        }

        public void UpdateNavigationItems()
        {
            records = registryController.GetPage();
            registryGrid.DataSource = records.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
            totalPages = (int)Math.Ceiling((double)records.Count() / PageSize);
            currentPageBox.Text = $"{CurrentPage} / {totalPages}";
        }

        public void UpdateNavigationItems(string query)
        {
            records = registryController.GetPage(query);
            registryGrid.DataSource = records.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
            totalPages = (int)Math.Ceiling((double)records.Count() / PageSize);
            currentPageBox.Text = $"{CurrentPage} / {totalPages}";
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            UpdateNavigationItems();
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            UpdateNavigationItems();
        }

        private void Registry_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void InitializeControllers()
        {
            catchingCardController = CatchingCardController.GetInstance();
            registryController = RegistryController.GetInstance();
        }

        private void InitializeDataGrid()
        {
            records = registryController.GetPage();
            registryGrid.DataSource = records.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();

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

        private void registryGrid_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = registryGrid.Columns[e.ColumnIndex];
            var filterFormResponse = new Filter(registryFilter, column).ShowDialog();

            if (filterFormResponse == DialogResult.OK)
            {
                var query = queryBuilder.SelectFrom("CatchingActs").ByCondition(registryFilter).GetResult();
                UpdateNavigationItems(query);
            }
        }

        private void resetFilterBtn_Click(object sender, EventArgs e)
        {
            InitializeFilter();
            var query = queryBuilder.SelectFrom("CatchingActs").ByCondition(registryFilter).GetResult();
            UpdateNavigationItems(query);
        }
    }
}