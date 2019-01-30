using Microsoft.EntityFrameworkCore;

namespace Northwind.DataLayer.Entities
{
    public partial class NorthwindContext : DbContext
    {
        private readonly string _connectionString;

        public NorthwindContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
        //public virtual DbSet<Customer> Customers { get; set; }
        //public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        //public virtual DbSet<Employee> Employees { get; set; }
        //public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        //public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        //public virtual DbSet<Region> Region { get; set; }
        //public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        //public virtual DbSet<Territory> Territories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NorthwindContext).Assembly);
        }
    }
}
