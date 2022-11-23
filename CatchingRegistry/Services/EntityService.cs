using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq.Expressions;
using Equin.ApplicationFramework;


namespace CatchingRegistry.Services
{
    public class EntityService<T> where T : class
    {
        private ApplicationContext context;
        private DbSet<T> dbSet;
        public EntityService(ApplicationContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public BindingListView<T> GetDataSource()
        {
            return new BindingListView<T>(dbSet.Local.ToBindingList());
        }

        public IQueryable<T>? GetAllBy(Expression<Func<T, bool>> predicate) => dbSet.Where(predicate);

        public T? GetBy(Expression<Func<T, bool>> predicate) => dbSet.FirstOrDefault(predicate);

        public T? GetByID(int ID) => dbSet.Find(ID);

        public void Add(T entity)
        {
            try
            {
                dbSet.Add(entity);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception("Ошибка сохранения элемента.", ex);
            }
        }

        public void Delete(int ID)
        {
            var item = GetByID(ID);
            try
            {
                dbSet.Remove(item);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления элемента.", ex);
            }
        }

        public void Edit(T entity)
        {
            try
            {
                dbSet.Update(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка обновления элемента.", ex);
            }
        }
    }
}
