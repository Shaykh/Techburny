using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechburnyStore.Core.Domain.HumanResources;

namespace TechburnyStore.Core.Domain.Configurations.HumanResources
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Mapping for table
            builder.ToTable("Employee", "HumanResources");

            // Set key for entity
            builder.HasKey(p => p.ID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ID).UseSqlServerIdentityColumn();

            // Set mapping for columns
            builder.Property(p => p.ID).HasColumnType("int").IsRequired();
            builder.Property(p => p.FirstName).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.MiddleName).HasColumnType("varchar(25)");
            builder.Property(p => p.LastName).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.BirthDate).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            builder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            builder
                .Property(p => p.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();
        }
    }
}