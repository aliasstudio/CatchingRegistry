using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq.Expressions;
using Equin.ApplicationFramework;


namespace CatchingRegistry.Services
{
    public static class EntityService {
        static readonly ApplicationContext context = new();
        public static ApplicationContext GetContext() => context;
    }

    public static class EntityService<T> where T : class
    {
        static ApplicationContext context = EntityService.GetContext();
        static DbSet<T> dbSet = context.Set<T>();

        public static BindingListView<T> GetDataSource()
        {
            return new BindingListView<T>(dbSet.Local.ToBindingList());
        }

        public static IQueryable<T>? GetAllBy(Expression<Func<T, bool>> predicate) => dbSet.Where(predicate);

        public static T? GetBy(Expression<Func<T, bool>> predicate) => dbSet.FirstOrDefault(predicate);

        public static T? GetByID(int ID) => dbSet.Find(ID);

        public static void Add(T entity)
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

        public static void Delete(int ID)
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

        public static void Edit(T entity)
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
