using CatchingRegistry.Models;
using CatchingRegistry.Services;

namespace CatchingRegistry.Controllers
{
    public class AuthController
    {
        private static AuthController instance;
        private static AuthService authService;

        public static AuthController GetInstance()
        {
            if (instance == null)
                instance = new AuthController();
            return instance;
        }

        public AuthController()
        {
            authService = AuthService.GetInstance();
        }

        public static User? AuthorizedUser { get; private set; } = null;
        public void Authorize(string userName, string userPassword)
        {
            if (userName.Length < 1 || userPassword.Length < 1)
                throw new Exception("Одно из полей не заполненно");

            var user = authService.Authorize(userName, userPassword);

            if (user != null)
                AuthorizedUser = user;
            else
                throw new Exception("Пользователь не найден");
        }
    }
}