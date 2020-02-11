using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechburnyStore.Core.Domain.Sales;

namespace TechburnyStore.Core.Domain.Configurations.Sales
{
    public class OrderHeaderConfiguration : IEntityTypeConfiguration<OrderHeader>
    {
        public void Configure(EntityTypeBuilder<OrderHeader> builder)
        {
            // Mapping for table
            builder.ToTable("OrderHeader", "Sales");

            // Set key for entity
            builder.HasKey(p => p.ID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ID).UseSqlServerIdentityColumn();

            // Set mapping for columns
            builder.Property(p => p.OrderStatusID).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.OrderDate).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.CustomerID).HasColumnType("int").IsRequired();
            builder.Property(p => p.EmployeeID).HasColumnType("int");
            builder.Property(p => p.ShipperID).HasColumnType("int");
            builder.Property(p => p.Total).HasColumnType("decimal(12, 4)").IsRequired();
            builder.Property(p => p.CurrencyID).HasColumnType("varchar(10)");
            builder.Property(p => p.PaymentMethodID).HasColumnType("uniqueidentifier");
            builder.Property(p => p.DetailsCount).HasColumnType("int").IsRequired();
            builder.Property(p => p.ReferenceOrderID).HasColumnType("bigint");
            builder.Property(p => p.Comments).HasColumnType("varchar(max)");
            builder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            builder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Add configuration for foreign keys
            builder
                .HasOne(p => p.OrderStatusFk)
                .WithMany(b => b.Orders)
                .HasForeignKey(p => p.OrderStatusID);

            builder
                .HasOne(p => p.CustomerFk)
                .WithMany(b => b.Orders)
                .HasForeignKey(p => p.CustomerID);

            builder
                .HasOne(p => p.ShipperFk)
                .WithMany(b => b.Orders)
                .HasForeignKey(p => p.ShipperID);
        }
    }
}