using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;

namespace CatchingRegistry
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CatchingAct> CatchingActs { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<MunicipalContract> MunicipalContracts { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AttachedFile> Files { get; set; }
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlite(@$"DataSource={path}\DB\app.db");
        }
    }
}