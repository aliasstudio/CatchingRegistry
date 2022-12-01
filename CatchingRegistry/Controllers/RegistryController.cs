using CatchingRegistry.Models;
using CatchingRegistry.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace CatchingRegistry.Controllers
{
    public class RegistryController
    {
        private static RegistryController instance;
        private RegistryService registryService;

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

            return instance;
        }

        public RegistryController()
        {
            registryService = RegistryService.GetInstance();
        }

        public List<CatchingAct> GetPage()
        {
            return registryService.GetPage();
        }

        public List<CatchingAct> GetPage(string query)
        {
            return registryService.GetPage(query);
        }
    }
}