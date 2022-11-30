using CatchingRegistry.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchingRegistry.Views
{
    public partial class Filter : Form
    {
        private RegistryController registryController;
        private Dictionary<string, string> dictionary;
        private DataGridViewColumn column;

        public Filter(Dictionary<string, string> dictionary, DataGridViewColumn column)
        {
            InitializeComponent();
            this.registryController = RegistryController.GetInstance();
            this.column = column;
            this.dictionary = dictionary;

            filterLabel.Text = column.HeaderText;
            filterBox.Text = dictionary[column.Name];
        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            dictionary[column.Name] = filterBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void filterResetBtn_Click(object sender, EventArgs e)
        {
            //TODO: сброс фильтра
/*            filterBox.Text = "";
            dictionary[columnName] = filterBox.Text;
            this.DialogResult = DialogResult.OK;*/
        }
    }
}
