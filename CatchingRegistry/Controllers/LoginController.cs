using CatchingRegistry.Models;
using CatchingRegistry.Views;

namespace CatchingRegistry.Controllers
{
    public class LoginController
    {
        public void Authorize(string userName, string userPassword)
        {
            using (var db = new ApplicationContext())
            {
                var user = db.Employees.FirstOrDefault(
                    user 
                    => user.Name == userName 
                    && user.Password == userPassword
                );

                if (user != null)
                    new Registry().Show();
                else
                    MessageBox.Show("Ошибка");
            }
        }
    }
}
