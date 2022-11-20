using CatchingRegistry.Controllers;
using CatchingRegistry.Models;

namespace CatchingRegistry.Views
{
    public partial class Auth : Form
    {
        private AuthController authController = new();
        public Auth()
        {
            InitializeComponent();

            //Debug
            userNameBox.Text = "admin";
            userPasswordBox.Text = "admin";
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            try
            {
                authController.Authorize(userNameBox.Text, userPasswordBox.Text);
                new Registry().Show();
                this.Hide();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
