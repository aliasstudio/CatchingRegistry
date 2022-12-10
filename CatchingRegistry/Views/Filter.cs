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
        private Dictionary<string, string> dictionary;
        private DataGridViewColumn column;

        public Filter(Dictionary<string, string> dictionary, DataGridViewColumn column)
        {
            InitializeComponent();
            this.column = column;
            this.dictionary = dictionary;

            filterLabel.Text = column.HeaderText;

            if (dictionary[column.Name].Length > 0)
            {
                if (dictionary[column.Name].Split('&')[0].Length > 0)
                {
                    filterBox.Text = dictionary[column.Name].Split('&')[0];
                }

                if (dictionary[column.Name].Split('&')[1].Length > 0)
                {
                    var sort = dictionary[column.Name].Split('&')[1] == "DESC" ? 1 : 0;
                    sortCombo.SelectedIndex = sort;
                }
            }
        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            var sort = (sortCombo.Text == "По убыванию") ? "DESC" : "ASC";
            dictionary[column.Name] = filterBox.Text + "&" + sort;
            this.DialogResult = DialogResult.OK;
        }
    }
}
