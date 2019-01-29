using Microsoft.EntityFrameworkCore;

namespace Northwind.DataLayer.Entities
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NorthwindContext).Assembly);


            //modelBuilder.Entity<CategoryLang>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            //    entity.Property(e => e.CategoryName).HasMaxLength(15);

            //    entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            //});

            //modelBuilder.Entity<CustomerCustomerDemo>(entity =>
            //{
            //    entity.HasKey(e => new { e.CustomerId, e.CustomerTypeId })
            //        .ForSqlServerIsClustered(false);

            //    entity.Property(e => e.CustomerId)
            //        .HasColumnName("CustomerID")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.CustomerTypeId)
            //        .HasColumnName("CustomerTypeID")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Id)
            //        .HasColumnName("ID")
            //        .ValueGeneratedOnAdd();

            //    entity.HasOne(d => d.Customer)
            //        .WithMany(p => p.CustomerCustomerDemo)
            //        .HasForeignKey(d => d.CustomerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CustomerCustomerDemo_Customers");

            //    entity.HasOne(d => d.CustomerType)
            //        .WithMany(p => p.CustomerCustomerDemo)
            //        .HasForeignKey(d => d.CustomerTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CustomerCustomerDemo");
            //});

            //modelBuilder.Entity<CustomerDemographics>(entity =>
            //{
            //    entity.HasKey(e => e.CustomerTypeId)
            //        .ForSqlServerIsClustered(false);

            //    entity.Property(e => e.CustomerTypeId)
            //        .HasColumnName("CustomerTypeID")
            //        .HasMaxLength(10)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.CustomerDesc).HasColumnType("ntext");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("ID")
            //        .ValueGeneratedOnAdd();
            //});

            //modelBuilder.Entity<CustomerDetails>(entity =>
            //{
            //    entity.Property(e => e.Id)
            //        .HasColumnName("ID")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Email).HasMaxLength(100);

            //    entity.Property(e => e.LastContactDate).HasColumnType("datetime");

            //    entity.Property(e => e.SendBulletin)
            //        .IsRequired()
            //        .HasDefaultValueSql("((1))");

            //    entity.HasOne(d => d.LastContactedByNavigation)
            //        .WithMany(p => p.CustomerDetails)
            //        .HasForeignKey(d => d.LastContactedBy)
            //        .HasConstraintName("FK_CustomerDetails_LastContactedBy");
            //});

            //modelBuilder.Entity<CustomerRepresentatives>(entity =>
            //{
            //    entity.HasKey(e => e.RepresentativeId);

            //    entity.Property(e => e.RepresentativeId).HasColumnName("RepresentativeID");

            //    entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            //    entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            //});

            //modelBuilder.Entity<DragDropSample>(entity =>
            //{
            //    entity.Property(e => e.Title)
            //        .IsRequired()
            //        .HasMaxLength(100);
            //});



            //modelBuilder.Entity<Notes>(entity =>
            //{
            //    entity.HasKey(e => e.NoteId);

            //    entity.Property(e => e.NoteId).HasColumnName("NoteID");

            //    entity.Property(e => e.EntityId).HasColumnName("EntityID");

            //    entity.Property(e => e.EntityType)
            //        .IsRequired()
            //        .HasMaxLength(100);

            //    entity.Property(e => e.InsertDate).HasColumnType("datetime");

            //    entity.Property(e => e.Text).IsRequired();
            //});


            //modelBuilder.Entity<ProductLang>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

            //    entity.Property(e => e.ProductId).HasColumnName("ProductID");

            //    entity.Property(e => e.ProductName).HasMaxLength(40);
            //});

            //modelBuilder.Entity<ProductLog>(entity =>
            //{
            //    entity.Property(e => e.ProductLogId).HasColumnName("ProductLogID");

            //    entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            //    entity.Property(e => e.ProductId).HasColumnName("ProductID");

            //    entity.Property(e => e.ProductImage).HasMaxLength(100);

            //    entity.Property(e => e.ProductName).HasMaxLength(40);

            //    entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);

            //    entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            //    entity.Property(e => e.UnitPrice).HasColumnType("money");

            //    entity.Property(e => e.ValidFrom).HasColumnType("datetime");

            //    entity.Property(e => e.ValidUntil).HasColumnType("datetime");
            //});

        }

        
    }
}
