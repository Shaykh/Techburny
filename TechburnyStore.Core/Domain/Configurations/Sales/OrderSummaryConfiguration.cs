using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechburnyStore.Core.Domain.Sales;

namespace TechburnyStore.Core.Domain.Configurations.Sales
{
    public class OrderSummaryConfiguration : IEntityTypeConfiguration<OrderSummary>
    {
        public void Configure(EntityTypeBuilder<OrderSummary> builder)
        {
            // Mapping for table
            builder.ToTable("OrderSummary", "Sales");

            // Set key for entity
            builder.HasKey(p => p.OrderID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.OrderID).HasColumnType("int").IsRequired();

            // Set mapping for columns
            builder.Property(p => p.OrderDate).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.CustomerName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.EmployeeName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.ShipperName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.OrderLines).HasColumnType("int").IsRequired();
        }
    }
}