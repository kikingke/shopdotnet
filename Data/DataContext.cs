using Microsoft.EntityFrameworkCore;
using shopdotnet.Data.Entities;
using System.Reflection.Metadata;

namespace shopdotnet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //crear indice por campo Name
            modelBuilder.Entity<Country>().HasIndex(c => c.Country_Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Category_Name).IsUnique();

            //indice compuestos

            modelBuilder.Entity<State>().Property<int>("CountryId");
            modelBuilder.Entity<State>().HasIndex("State_Name", "CountryId").IsUnique();
            modelBuilder.Entity<City>().Property<int>("StateId");
            modelBuilder.Entity<City>().HasIndex("City_Name", "StateId").IsUnique();
            // modelBuilder.Entity<State>().HasAlternateKey("State_Name").HasName("CountryId");
           // modelBuilder.Entity<City>().HasAlternateKey("City_Name").HasName("StateId");
           //modelBuilder.Entity<City>().HasIndex("City_Name", "StateId").IsUnique();
        }

    }
}
