using CatchingRegistry.Models;
using CatchingRegistry.Views;

namespace CatchingRegistry.Controllers.Auth
{
    public class AuthController
    {
        public Employee? AuthorizedUser { get; private set; } = null;
        public void Authorize(string userName, string userPassword)
        {
            try
            {
                //Валидацию нужно переделать, вынести в отдельный метод мб
                if (userName.Length < 1 || userPassword.Length < 1)
                    throw new Exception("Одно из полей не заполненно");
                //
                using (var db = new ApplicationContext())
                {
                    var user = db.Employees.FirstOrDefault(
                        user
                        => user.Name == userName
                        && user.Password == userPassword
                    );

                    if (user != null)
                    {
                        AuthorizedUser = user;
                        new Registry().Show();
                    } else
                    {
                        throw new Exception("Пользователь не найден");
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
