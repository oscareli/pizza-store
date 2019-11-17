using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PizzaStore.ApplicationCore.Entities;

namespace PizzaStore.Infrastructure.Data
{
    public class PizzaOrderContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public PizzaOrderContext(DbContextOptions<PizzaOrderContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaOrder>().ToTable("TB_PIZZA_ORDER");
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PizzaOrderContext>
    {
        public PizzaOrderContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/EntityConfig/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<PizzaOrderContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new PizzaOrderContext(builder.Options);
        }
    }
}
