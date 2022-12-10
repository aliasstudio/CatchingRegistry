using CatchingRegistry.Models;
using CatchingRegistry.Services;

namespace CatchingRegistry.Controllers
{
    public class RegistryController
    {
        private static RegistryController? instance;
        private RegistryService registryService;

        int currentPage = 1;
        public int TotalPages { get; private set; }
        public int PageSize { get; set; } = 10;
        public int CurrentPage { 
            get => currentPage; 
            set
            {
                if(value > 0 && value <= TotalPages)
                    currentPage = value;
            }
        }
        public string Filter { get; set; } = null;

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
            IQueryable<CatchingAct> dataSet;
            if (Filter != null)
                dataSet = registryService.GetPage(Filter);
            else
                dataSet = registryService.GetPage();
            TotalPages = (int)Math.Ceiling((double)dataSet.Count() / PageSize);
            return dataSet
                    .Skip((CurrentPage - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
        }
    }
}