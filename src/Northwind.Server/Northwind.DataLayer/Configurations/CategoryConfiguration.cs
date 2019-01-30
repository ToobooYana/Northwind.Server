using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.DataLayer.Entities;

namespace Northwind.DataLayer.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id).HasName("CategoryID");

            builder.HasIndex(e => e.CategoryName)
                .HasName("CategoryName");

            builder.Property(e => e.Id).HasColumnName("CategoryID");

            builder.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(e => e.Description).HasColumnType("ntext");

            //builder.Property(e => e.Picture).HasColumnType("image");
        }
    }
}