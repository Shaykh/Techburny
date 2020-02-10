using System.Collections.ObjectModel;

namespace TechburnyStore.Core.Domain.Warehouse
{
    public class ProductCategory : AuditableEntity
    {
        public int? ID { get; set; }

        public string ProductCategoryName { get; set; }

        public virtual Collection<Product> Products { get; set; }

        public ProductCategory()
        {
        }

        public ProductCategory(int? id)
        {
            ID = id;
        }
    }
}