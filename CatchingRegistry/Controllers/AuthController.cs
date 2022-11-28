using CatchingRegistry.Models;

namespace CatchingRegistry.Controllers
{
    public class AuthController
    {
        private static AuthController instance;
        private static ApplicationContext ctx;

        public static AuthController GetInstance()
        {
            if (instance == null)
                instance = new AuthController();
            ctx = new();
            return instance;
        }

        public static User? AuthorizedUser { get; private set; } = null;
        public void Authorize(string userName, string userPassword)
        {
            if (userName.Length < 1 || userPassword.Length < 1)
                throw new Exception("Одно из полей не заполненно");

            var user = ctx.Employees.FirstOrDefault(
                user 
                => user.Name == userName
                && user.Password == userPassword
            );
            if (user != null)
                AuthorizedUser = user;
            else
                throw new Exception("Пользователь не найден");
        }
    }
}
