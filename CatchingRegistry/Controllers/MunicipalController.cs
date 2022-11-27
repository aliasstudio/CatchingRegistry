using CatchingRegistry.Models;

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
            return instance;
        }

        public List<MunicipalContract> GetAllByOrganizationID(int organizationID)
        {
            return ctx.MunicipalContracts
                .Where(contract => contract.Organization.ID == organizationID)
                .ToList();
        }
    }
}
