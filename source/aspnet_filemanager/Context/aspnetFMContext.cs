using aspnet_filemanager.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace aspnet_filemanager.Context
{
    public class aspnetFMContext : DbContext
    {
        public aspnetFMContext() : base("aspnetFileManager")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<File> File { get; set; }
        public DbSet<Folder> Customer { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<User> User { get; set; }
    }
}