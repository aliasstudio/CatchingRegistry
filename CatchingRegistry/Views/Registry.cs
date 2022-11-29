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
        private List<CatchingAct> records;
        private int currentPage = 1;
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
            totalPages = records.Count() / PageSize;
            currentPageBox.Text = $"{currentPage} / {totalPages}";
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
                new CatchingCard(itemID).Show();
            } 
            catch(Exception ex)
            {
                MessageBox.Show($"Ни одна запись не выделена. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void registryAddBtn_Click(object sender, EventArgs e)
        {
            new CatchingCard().Show();
        }

        private void registryDeleteBtn_Click(object sender, EventArgs e)
        {
            try 
            { 
                var itemID = (int)registryGrid[0, registryGrid.SelectedRows[0].Index].Value;
                catchingCardController.Delete(itemID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления записи. {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageSizeApplyBtn_Click(object sender, EventArgs e)
        {
            PageSize = registryPageSizeBox.Value;
            totalPages = (int)Math.Ceiling((double)records.Count() / PageSize);
            currentPage = 1;
            currentPageBox.Text = $"{currentPage} / {totalPages}";
            registryGrid.DataSource = records.Skip((currentPage - 1) * PageSize).Take(PageSize).ToList();

            //registryController.PageSize = registryPageSizeBox.Value;
            //if (registryController.TotalPages < 2)
            //    registryController.CurrentPage = 1;
            //UpdateGrid();
        }

        private void registryPageSizeBox_ValueChanged(object sender, EventArgs e)
        {
            pageSliderLabel.Text = registryPageSizeBox.Value.ToString();
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            currentPage++;
            if (currentPage > totalPages || currentPage < 1)
            {
                currentPage--;
                return;
            }

            registryGrid.DataSource = records.Skip((currentPage - 1) * PageSize).Take(PageSize).ToList();
            currentPageBox.Text = $"{currentPage} / {totalPages}";
            //registryController.CurrentPage++;
            //UpdateGrid();
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            currentPage--;
            if (currentPage > totalPages || currentPage < 1)
            {
                currentPage++;
                return;
            }

            registryGrid.DataSource = records.Skip((currentPage - 1) * PageSize).Take(PageSize).ToList();
            currentPageBox.Text = $"{currentPage} / {totalPages}";
            //registryController.CurrentPage--;
            //UpdateGrid();
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
            registryGrid.DataSource = records.Skip((currentPage - 1) * PageSize).Take(PageSize).ToList();

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


        private void registryGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnName = registryGrid.Columns[e.ColumnIndex].Name;
            var filterFormResponse = new Filter(registryFilter, columnName).ShowDialog();


            if (filterFormResponse == DialogResult.OK)
            {
                StringBuilder queryBuilder = new StringBuilder("SELECT ");
                List<string> filterConditions = new List<string>();




                foreach (KeyValuePair<string, string> filter in registryFilter)
                {
                    queryBuilder.Append($"{filter.Key}");

                    if (registryFilter.Last().Key != filter.Key)
                        queryBuilder.Append(", ");
                    else
                        queryBuilder.Append(" ");
                }



                queryBuilder.Append("FROM CatchingActs");




                // TODO: Для двух и более параметров добавить AND
                foreach (KeyValuePair<string, string> filter in registryFilter)
                {
                    if (filter.Value != "")
                    {
                        if (!queryBuilder.ToString().Contains(" WHERE "))
                            queryBuilder.Append(" WHERE ");

                        filterConditions.Add($" {filter.Key} LIKE '%{filter.Value}%'");
                    }
                }

                if (filterConditions.Count > 1)
                {
                    var conditions = string.Join(" AND ", filterConditions);
                    queryBuilder.Append(conditions);
                }
                else if (filterConditions.Count == 1)
                {
                    queryBuilder.Append(filterConditions[0]);
                }



                
                registryGrid.DataSource = registryController.GetPage(queryBuilder.ToString());



                if (registryController.TotalPages < 2)
                    registryController.CurrentPage = 1;
                currentPageBox.Text = $"{registryController.CurrentPage} / {registryController.TotalPages}";
            }
        }
    }
}