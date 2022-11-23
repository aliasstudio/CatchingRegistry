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
        private int pageSize = 5;
        private int currentPage = 1;
        private IQueryable<CatchingAct> registryLocal = EntityService
                .GetContext().CatchingActs
                .Include(x => x.MunicipalContract)
                .Include(x => x.Animals)
                .Include(x => x.Files);
        public BindingListView<CatchingAct> GetDataSource()
        {
            registryLocal
                .Take(pageSize)
                .Load();

            return EntityService<CatchingAct>.GetDataSource();
        }

        public void Delete(int ID)
        {
            EntityService<CatchingAct>.Delete(ID);
            registryLocal
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .Load();
        }

        public void SetPageSize(int size)
        {
            //Мб потом в свойство переделать 
            pageSize = size;
            registryLocal
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .Load();
        }

        public void NextPage()
        {
            var query = registryLocal
                .Skip(currentPage * pageSize)
                .Take(pageSize);
            if(query.Count() > 0)
            {
                //EntityService.GetContext().CatchingActs.Local.Clear();
                query.Load();
                currentPage++;
            }
        }

        public void PreviosPage()
        {
            //TODO: Fix назад не перелистывает
            var query = registryLocal
                .Skip((currentPage - 2) * pageSize)
                .Take(pageSize);
            if (query.Count() > 0)
            {
                //EntityService.GetContext().CatchingActs.Local.Clear();
                query.Load();
                currentPage--;
            }
        }
    }
}
