using Microsoft.EntityFrameworkCore;
using TechburnyStore.Core.Domain.Dbo;

namespace TechburnyStore.Core.Domain
{
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<ChangeLog> ChangeLogs { get; set; }

        public DbSet<ChangeLogExclusion> ChangeLogExclusions { get; set; }

        public DbSet<CountryCurrency> CountryCurrencies { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<EventLog> EventLogs { get; set; }
        /*
        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }

        public DbSet<EmployeeEmail> EmployeeEmails { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductInventory> ProductInventories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductUnitPriceHistory> ProductUnitPriceHistories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderHeader> OrderHeaders { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<OrderSummary> OrderSummaries { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations

            modelBuilder
                .ApplyConfiguration(new ChangeLogConfiguration())
                .ApplyConfiguration(new ChangeLogExclusionConfiguration())
                .ApplyConfiguration(new CountryCurrencyConfiguration())
                .ApplyConfiguration(new CountryConfiguration())
                .ApplyConfiguration(new CurrencyConfiguration())
                .ApplyConfiguration(new EventLogConfiguration())
                ;

            modelBuilder
                .ApplyConfiguration(new EmployeeConfiguration())
                .ApplyConfiguration(new EmployeeAddressConfiguration())
                .ApplyConfiguration(new EmployeeEmailConfiguration())
                ;

            modelBuilder
                .ApplyConfiguration(new ProductCategoryConfiguration())
                .ApplyConfiguration(new ProductConfiguration())
                .ApplyConfiguration(new ProductUnitPriceHistoryConfiguration())
                .ApplyConfiguration(new ProductInventoryConfiguration())
                .ApplyConfiguration(new LocationConfiguration())
                ;

            modelBuilder
                .ApplyConfiguration(new CustomerConfiguration())
                .ApplyConfiguration(new OrderDetailConfiguration())
                .ApplyConfiguration(new OrderHeaderConfiguration())
                .ApplyConfiguration(new OrderStatusConfiguration())
                .ApplyConfiguration(new OrderSummaryConfiguration())
                .ApplyConfiguration(new PaymentMethodConfiguration())
                .ApplyConfiguration(new ShipperConfiguration())
                ;

            base.OnModelCreating(modelBuilder);
        }
        */
    }
}