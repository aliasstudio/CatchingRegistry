using CatchingRegistry.Models;
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
        private static ApplicationContext ctx;

        public static RegistryService GetInstance()
        {
            if (instance == null)
                instance = new RegistryService();
            ctx = new();
            return instance;
        }

        public List<CatchingAct> GetPage()
        {
            ctx = new();
            return ctx.CatchingActs.ToList();
        }

        public List<CatchingAct> GetPage(string query)
        {
            ctx = new();
            return ctx.CatchingActs.FromSqlRaw(query).ToList();
        }
    }
}
