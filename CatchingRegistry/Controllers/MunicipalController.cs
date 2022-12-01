using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry.Controllers
{
    public class MunicipalController
    {
        private static MunicipalController instance;
        private static ApplicationContext ctx = new();

        public static MunicipalController GetInstance()
        {
            if (instance == null)
                instance = new MunicipalController();
            ctx = new();
            return instance;
        }

        public MunicipalContract? GetByID(int mID) => ctx.MunicipalContracts.FirstOrDefault(x => x.ID == mID);

        public List<MunicipalContract> GetAllByOrganizationID(int organizationID)
        {
            return ctx.MunicipalContracts
                .Where(contract => contract.Organization.ID == organizationID)
                .ToList();
        }
    }
}
