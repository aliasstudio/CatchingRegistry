using CatchingRegistry.Models;
using CatchingRegistry.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Services
{
    public class AuthService
    {
        public static AuthService instance;
        private static ApplicationContext ctx;

        public static AuthService GetInstance()
        {
            if (instance == null)
                instance = new AuthService();
            ctx = new();
            return instance;
        }

        public User? Authorize(string userName, string userPassword)
        {
            return ctx.Employees.FirstOrDefault(
                user
                => user.Name == userName
                && user.Password == userPassword
            );
        }
    }
}
