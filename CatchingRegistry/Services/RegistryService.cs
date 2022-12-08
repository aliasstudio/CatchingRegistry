using CatchingRegistry.Controllers;
using CatchingRegistry.Models;
using CatchingRegistry.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Services
{
    public class RegistryService
    {
        public static RegistryService instance;

        public static RegistryService GetInstance()
        {
            if (instance == null)
                instance = new RegistryService();
            return instance;
        }

        private List<CatchingAct> GetActsByPermission(string query = "")
        {
            IQueryable<CatchingAct> ctx = query.Length > 0 
                ? new ApplicationContext().CatchingActs.FromSqlRaw(query)
                : new ApplicationContext().CatchingActs;

            if (AuthController.AuthorizedUser.Role.Visibility == 0)
                return ctx.ToList();
            else if (AuthController.AuthorizedUser.Role.Visibility == 1)
                return ctx
                    .Include(x => x.MunicipalContract)
                    .Where(x => x.MunicipalContract.Contractor.ID == AuthController.AuthorizedUser.Organization.ID)
                    .ToList();
            else
                return ctx
                    .Include(x => x.MunicipalContract)
                        .ThenInclude(x => x.Contractor)
                    .Where(x => x.MunicipalContract.LocalGovernment.ID == AuthController.AuthorizedUser.Organization.ID)
                    .ToList();
        }

        public List<CatchingAct> GetPage() => GetActsByPermission();

        public List<CatchingAct> GetPage(string query) => GetActsByPermission(query);
    }
}
