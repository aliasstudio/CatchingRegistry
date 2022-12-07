using CatchingRegistry.Models;
using CatchingRegistry.Utils;
using Microsoft.EntityFrameworkCore;
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

        public static AuthService GetInstance()
        {
            if (instance == null)
                instance = new AuthService();
            return instance;
        }

        public User? Authorize(string userName, string userPassword)
            => new ApplicationContext().Employees
                    .Include(x => x.Organization)
                    .Include(x => x.Role)
                    .FirstOrDefault(
                        user
                        => user.Name == userName
                        && user.Password == userPassword);
    }
}
