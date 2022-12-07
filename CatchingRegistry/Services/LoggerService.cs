using CatchingRegistry.Models;
using CatchingRegistry.Controllers;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

namespace CatchingRegistry.Services
{
    public class LoggerService
    {
        public static void Add<T>(T logData) where T : class
        {
            var user = AuthController.AuthorizedUser;
            var method = new StackTrace(1).GetFrame(0).GetMethod();
            var operation = method.IsConstructor ? $"{method.DeclaringType.Name}Open" : method.Name;
            StringBuilder parameters = new();

            if(logData.GetType().Equals(typeof(string)))
                parameters.Append(logData);
            else
                parameters.Append(JsonConvert.SerializeObject(logData));

            var log = new Log()
            {
                User = $"ID: {user.ID}, Name: {user.Name}",
                Date = DateTime.Now.ToString("dd.MM.yyyy - HH:mm:ss"),
                Operation = operation,
                Parameters = parameters.ToString()
            };

            using var ctx = new ApplicationContext();
            ctx.Logs.Add(log);
            ctx.SaveChanges();
        }
    }
}
