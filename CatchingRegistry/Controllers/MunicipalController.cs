using CatchingRegistry.Models;
using CatchingRegistry.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Controllers
{
    public class MunicipalController
    {
        private ApplicationContext contractContext;
        private EntityService<MunicipalContract> entityService;

        public MunicipalController()
        {
            contractContext = new();
            entityService = new(contractContext);
        }

        public List<MunicipalContract> GetAllByOrganizationID(int organizationID)
        {
            return entityService
                .GetAllBy(contract => contract.Organization.ID == organizationID)
                .ToList();
        }
    }
}
