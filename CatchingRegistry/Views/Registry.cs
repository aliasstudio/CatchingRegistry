using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using CatchingRegistry.Services;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry.Views
{
    public partial class Registry : Form
    {
        RegistryController registryController = new();
        public Registry()
        {
            InitializeComponent();
            registryGrid.DataSource = registryController.GetDataSource();
        }

        private void registryAddBtn_Click(object sender, EventArgs e)
        {
            var testItem = new CatchingAct { 
                DateTime = DateTime.Now.ToUniversalTime(), 
                CatchingAddress = "123",
                CatchingPurpose = "123",
                MunicipalContract = DataBaseService<MunicipalContract>.GetByID(0) 
            };
            registryController.Add(testItem);
        }

        private void registryDeleteBtn_Click(object sender, EventArgs e)
        {
            //registryController.Delete();
        }

        private void Registry_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit(); //Жоский код
    }
}