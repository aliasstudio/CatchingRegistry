using CatchingRegistry.Models;
using CatchingRegistry.Services;
using CatchingRegistry.Utils;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry.Controllers
{
    public class MunicipalController
    {
        private static MunicipalController instance;
        private static MunicipalService municipalService;

        public static MunicipalController GetInstance()
        {
            if (instance == null)
                instance = new MunicipalController();
            return instance;
        }

        public MunicipalController()
        {
            municipalService = MunicipalService.GetInstance();
        }

        public MunicipalContract? GetByID(int mID)
        {
            return municipalService.GetByID(mID);
        }

        public List<MunicipalContract> GetAllByOrganizationID(int organizationID)
        {
            return municipalService.GetAllByOrganizationID(organizationID);
        }
    }
}
