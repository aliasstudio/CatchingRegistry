using CatchingRegistry.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchingRegistry.Views
{
    public partial class Filter : Form
    {
        private RegistryController registryController;
        private DataGridView registryGrid;
        public Filter(DataGridView registryGrid)
        {
            InitializeComponent();
            this.registryGrid = registryGrid;
            registryController = RegistryController.GetInstance();
        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("SELECT * FROM Catching");
            var res = this.Controls.OfType<CheckBox>().ToList();

            foreach (var item in res)
            {
                var r1 = item.GetType().GetCustomAttributes(false);
            }
        }
    }

    public class CustomName : Attribute
    {
        public string name;
        public CustomName(string name) { this.name = name; }
    }
}
