using CatchingRegistry.Models;
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
        public int TotalPages => (int)Math.Ceiling((double)new ApplicationContext().CatchingActs.Count() / PageSize);
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
            return ctx.CatchingActs
                .Skip((currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList()
                .Select(x => { x.CatchingAddress = string.Join("", x.CatchingAddress.Split("&")); return x; })
                .ToList();
        }

        public List<CatchingAct> GetPage(Func<CatchingAct, bool> predicate)
        {
            return GetPage().Where(predicate).ToList();
        }
    }
}