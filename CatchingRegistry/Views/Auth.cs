using CatchingRegistry.Controllers.Auth;
using CatchingRegistry.Models;

namespace CatchingRegistry.Views
{
    public partial class Auth : Form
    {
        private AuthController authController = new AuthController();
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
