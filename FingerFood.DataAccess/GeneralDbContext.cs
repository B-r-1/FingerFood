using FingerFood.Base.DataAccess;
using FingerFood.Domain;
using FingerFood.Domain.Entities;
using System.Data.Entity;

namespace FingerFood.DataAccess
{
    public class GeneralDbContext : DbContext, IContext
    {
        public GeneralDbContext()
            : base("name=GeneralDbContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetails { get; set; }
        public DbSet<TableWaiter> TablesWaiters { get; set; }   


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
    