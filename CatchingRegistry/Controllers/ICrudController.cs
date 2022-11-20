using CatchingRegistry.Models;
using CatchingRegistry.Services;
using System.ComponentModel;

namespace CatchingRegistry.Controllers
{
    public abstract class ICrudController<T> where T : class
    {
        public BindingList<T> GetDataSource()
        {
            return DataBaseService<T>.GetDataSource();
        }
        public void Add(T entity)
        {
            DataBaseService<T>.Add(entity);
        }
    }
}
