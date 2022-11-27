using CatchingRegistry.Services;
using CatchingRegistry.Models;
using System.Data;
using System.ComponentModel;
using Equin.ApplicationFramework;
using Microsoft.EntityFrameworkCore;


namespace CatchingRegistry.Controllers
{
    public class RegistryController
    {
        ApplicationContext context;

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

        public RegistryController()
        {
            context = new();
        }

        public List<CatchingAct> GetPage()
        {
            return context.CatchingActs
                .Skip((currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }

        public void Delete(int ID)
        {
            context.CatchingActs.Remove(new CatchingAct { ID = 66 });
            context.SaveChanges();
        }
    }
}