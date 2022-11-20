using CatchingRegistry.Models;
using CatchingRegistry.Services;

namespace CatchingRegistry.Controllers
{
    public class AuthController
    {
        public User? AuthorizedUser { get; private set; } = null;
        public void Authorize(string userName, string userPassword)
        {
            //Валидацию нужно переделать, вынести в отдельный метод мб
            if (userName.Length < 1 || userPassword.Length < 1)
                throw new Exception("Одно из полей не заполненно");
            AuthorizedUser = UserService.IsExist(userName, userPassword);
        }
    }
}
