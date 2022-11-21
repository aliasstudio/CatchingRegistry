using CatchingRegistry.Models;
using CatchingRegistry.Services;

namespace CatchingRegistry.Controllers
{
    public class AuthController
    {
        public User? AuthorizedUser { get; private set; } = null;
        public void Authorize(string userName, string userPassword)
        {
            if (userName.Length < 1 || userPassword.Length < 1)
                throw new Exception("Одно из полей не заполненно");

            var user = EntityService<User>.GetBy(
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
