using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CatchingRegistry.Services
{
    public class DataBaseService<T> where T : class
    {
        static readonly ApplicationContext context = new();
        static readonly DbSet<T> dbSet = context.Set<T>();
        public static BindingList<T> GetDataSource()
        {
            dbSet.Load();
            return dbSet.Local.ToBindingList();
        }

        public static T GetByID(int ID)
        {
            var item = dbSet.Find(ID);
            if (item == null)
                throw new Exception("Элемент не найден");
            return item;
        }

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

        public static void Delete(T entity)
        {

        }

        public static void Edit(T entity)
        {

        }
    }
}
