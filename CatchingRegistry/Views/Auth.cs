using CatchingRegistry.Controllers;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CatchingRegistry.Views
{
    public partial class Auth : MaterialForm
    {
        private AuthController authController;
        public Auth()
        {
            InitializeComponent();
            InitializeTheme();

            authController = AuthController.GetInstance();

            //Debug
            userNameBox.Text = "admin";
            userPasswordBox.Text = "admin";
        }

        private void InitializeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
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
