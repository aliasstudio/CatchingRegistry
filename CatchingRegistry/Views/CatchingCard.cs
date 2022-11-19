using DocumentFormat.OpenXml.Packaging;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;
using CatchingRegistry.Controllers;

namespace CatchingRegistry.Views
{
    public partial class CatchingCard : Form
    {
        public CatchingCard()
        {
            InitializeComponent();
        }
    }
}
