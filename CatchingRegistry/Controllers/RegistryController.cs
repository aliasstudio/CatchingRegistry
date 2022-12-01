using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace CatchingRegistry.Controllers
{
    public class RegistryController
    {
        private static RegistryController instance;
        private static ApplicationContext ctx = new();

        private int currentPage = 1;
        public int PageSize { get; set; } = 10;

        private int totalPages;
        public int TotalPages
        {
            get => totalPages;
            set => totalPages = value;
        }

        public int CurrentPage 
        {
            get => currentPage;
            set {
                if (value > 0 && value <= TotalPages)
                    currentPage = value;
            }
        }

        public static RegistryController GetInstance()
        {
            if (instance == null)
                instance = new RegistryController();
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