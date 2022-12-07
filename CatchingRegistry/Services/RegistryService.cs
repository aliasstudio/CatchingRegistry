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
    public class RegistryService
    {
        public static RegistryService instance;

        public static RegistryService GetInstance()
        {
            if (instance == null)
                instance = new RegistryService();
            return instance;
        }

        public List<CatchingAct> GetPage()
            => new ApplicationContext().CatchingActs.ToList();

        public List<CatchingAct> GetPage(string query)
            => new ApplicationContext().CatchingActs.FromSqlRaw(query).ToList();
    }
}
