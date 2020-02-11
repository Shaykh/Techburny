using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechburnyStore.Core.Domain.Warehouse;

namespace TechburnyStore.Core.Domain.Configurations.Warehouse
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Mapping for table
            builder.ToTable("Product", "Warehouse");

            // Set key for entity
            builder.HasKey(p => p.ID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ID).UseSqlServerIdentityColumn();

            // Set mapping for columns
            builder.Property(p => p.ID).HasColumnType("int").IsRequired();
            builder.Property(p => p.ProductName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.ProductCategoryID).HasColumnType("int").IsRequired();
            builder.Property(p => p.UnitPrice).HasColumnType("decimal(8, 4)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("varchar(255)");
            builder.Property(p => p.Discontinued).HasColumnType("bit").IsRequired();
            builder.Property(p => p.Stocks).HasColumnType("int").IsRequired();
            builder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            builder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Add configuration for foreign keys
            builder
                .HasOne(p => p.ProductCategoryFk)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.ProductCategoryID);

            // Add configuration for uniques
            builder
                .HasAlternateKey(p => new { p.ProductName })
                .HasName("U_ProductName");
        }
    }
}