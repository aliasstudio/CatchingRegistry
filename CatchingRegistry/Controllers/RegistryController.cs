using CatchingRegistry.Models;
using System.Linq;
using System.Linq.Expressions;

namespace CatchingRegistry.Controllers
{
    public class RegistryController
    {
        static ApplicationContext ctx = new();

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
        public List<CatchingAct> GetPage()
        {
            return ctx.CatchingActs
                .Skip((currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }

        public List<CatchingAct> GetPage(Func<CatchingAct, bool> predicate)
        {
            return GetPage().Where(predicate).ToList();
        }

        public void Delete(int ID)
            => ctx.CatchingActs.Remove(CatchingCardController.GetByID(ID));
    }
}