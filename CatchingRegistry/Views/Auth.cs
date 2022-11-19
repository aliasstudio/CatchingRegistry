using CatchingRegistry.Controllers;
using CatchingRegistry.Models;

namespace CatchingRegistry.Views
{
    public partial class Auth : Form
    {
        private readonly AuthController authController = new();

        public Auth()
        {
            InitializeComponent();

            //Debug
            userNameBox.Text = "admin";
            userPasswordBox.Text = "admin";
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            authController.Authorize(userNameBox.Text, userPasswordBox.Text);
        }
    }
}
