using CatchingRegistry.Controllers;
using CatchingRegistry.Models;

namespace CatchingRegistry.Views
{
    public partial class Login : Form
    {
        private readonly LoginController loginController = new();

        public Login()
        {
            InitializeComponent();

            //Debug
            userNameBox.Text = "admin";
            userPasswordBox.Text = "admin";
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            loginController.Authorize(userNameBox.Text, userPasswordBox.Text);
        }
    }
}
