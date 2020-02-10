using System.Collections.ObjectModel;
using TechburnyStore.Core.Domain.Sales;

namespace TechburnyStore.Core.Domain.Warehouse
{
    public class Product : AuditableEntity
    {
        public int? ID { get; set; }

        public string ProductName { get; set; }

        public int? ProductCategoryID { get; set; }

        public decimal? UnitPrice { get; set; }

        public string Description { get; set; }

        public bool? Discontinued { get; set; }

        public int? Stocks { get; set; }

        public ProductCategory ProductCategoryFk { get; set; }

        public Collection<ProductInventory> ProductInventories { get; set; }

        public Collection<OrderDetail> OrderDetails { get; set; }

        public Product()
        {
        }

        public Product(int? id)
        {
            ID = id;
        }
    }
}