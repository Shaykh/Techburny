using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechburnyStore.Core.Domain.Sales;

namespace TechburnyStore.Core.Domain.Configurations.Sales
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            // Mapping for table
            builder.ToTable("OrderDetail", "Sales");

            // Set key for entity
            builder.HasKey(p => p.ID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ID).UseSqlServerIdentityColumn();

            // Set mapping for columns
            builder.Property(p => p.OrderHeaderID).HasColumnType("bigint").IsRequired();
            builder.Property(p => p.ProductID).HasColumnType("int").IsRequired();
            builder.Property(p => p.ProductName).HasColumnType("varchar(255)").IsRequired();
            builder.Property(p => p.UnitPrice).HasColumnType("decimal(8, 4)").IsRequired();
            builder.Property(p => p.Quantity).HasColumnType("int").IsRequired();
            builder.Property(p => p.Total).HasColumnType("decimal(8, 4)").IsRequired();
            builder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            builder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Add configuration for foreign keys
            builder
                .HasOne(p => p.OrderFk)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(p => p.OrderHeaderID);

            builder
                .HasOne(p => p.ProductFk)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(p => p.ProductID);
        }
    }
}