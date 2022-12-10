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

        public IQueryable<CatchingAct> GetPage(string query = "")
        {
            //IQueryable<CatchingAct> ctx = query.Length > 0
            //    ? new ApplicationContext().CatchingActs.FromSqlRaw(query)
            //    : new ApplicationContext().CatchingActs;
            ApplicationContext ctx = new();

            if (AuthController.AuthorizedUser.Role.Visibility == (int)Role.VisibilityType.All) {
                ctx.CatchingActs.AsQueryable();

            }
            else if (AuthController.AuthorizedUser.Role.Visibility == (int)Role.VisibilityType.Organization)
            {
                ctx.CatchingActs
                    .Include(x => x.MunicipalContract)
                    .Where(x => x.MunicipalContract.Contractor.ID == AuthController.AuthorizedUser.Organization.ID);
            }
            else
            {
                ctx.CatchingActs
                    .Include(x => x.MunicipalContract)
                        .ThenInclude(x => x.Contractor)
                    .Where(x => x.MunicipalContract.LocalGovernment.ID == AuthController.AuthorizedUser.Organization.ID)
                    .AsQueryable();
            }

            if (query.Length > 0)
                return ctx.CatchingActs.FromSqlRaw(query);
            else
                return ctx.CatchingActs;
        }
    }
}
