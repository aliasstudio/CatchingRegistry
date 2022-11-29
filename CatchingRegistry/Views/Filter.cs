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
        private string columnName;

        public Filter(Dictionary<string, string> dictionary, string columnName)
        {
            InitializeComponent();
            this.registryController = RegistryController.GetInstance();
            this.columnName = columnName;
            this.dictionary = dictionary;

            filterLabel.Text = columnName;
            filterBox.Text = dictionary[columnName];
        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            //BUG пустое значение дропает ошибку
            dictionary[columnName] = filterBox.Text;
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
