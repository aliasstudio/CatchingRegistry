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
        ApplicationContext registryContext;
        EntityService<CatchingAct> entityService;

        int currentPage = 1;
        public int PageSize { get; set; } = 5;
        public int TotalPages => (int)Math.Ceiling((double)new ApplicationContext().CatchingActs.Count() / PageSize);
        public int CurrentPage {
            get => currentPage;
            set {
                if (value > 0 && value <= TotalPages)
                    currentPage = value;
            }
        }

        public RegistryController()
        {
            registryContext = new();
            entityService = new(registryContext);
        }

        public BindingListView<CatchingAct> GetPage()
        {
            registryContext = new();
            entityService = new(registryContext);

            registryContext.CatchingActs
                .Skip((currentPage - 1) * PageSize)
                .Take(PageSize)
                .Load();

            return entityService.GetDataSource();
        }

        public void Delete(int ID)
        {
            entityService.Delete(ID);
        }
    }
}