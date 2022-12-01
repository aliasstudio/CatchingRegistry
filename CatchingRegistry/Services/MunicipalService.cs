using CatchingRegistry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Services
{
    public class MunicipalService
    {
        public static MunicipalService instance;
        public static ApplicationContext ctx;

        public static MunicipalService GetInstance()
        {
            if (instance == null)
                instance = new MunicipalService();
            ctx = new ApplicationContext();

            return instance;
        }


        public MunicipalContract? GetByID(int mID)
        {
            return ctx.MunicipalContracts.FirstOrDefault(x => x.ID == mID);
        }

        public List<MunicipalContract> GetAllByOrganizationID(int organizationID)
        {
            return ctx.MunicipalContracts
                .Where(contract => contract.Organization.ID == organizationID)
                .ToList();
        }
    }
}
