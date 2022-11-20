using CatchingRegistry.Models;

namespace CatchingRegistry.Services
{
    public class UserService
    {
        public static User IsExist(string userName, string userPassword)
        {
            using (var db = new ApplicationContext())
            {
                var user = db.Employees.FirstOrDefault(
                    user
                    => user.Name == userName
                    && user.Password == userPassword
                );

                if (user != null)
                    return user;
                else
                    throw new Exception("Пользователь не найден");
            }
        }
    }
}
