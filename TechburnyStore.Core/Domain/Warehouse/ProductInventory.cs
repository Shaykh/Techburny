namespace TechburnyStore.Core.Domain.Warehouse
{
    public class ProductInventory : AuditableEntity
    {
        public int? ID { get; set; }

        public int? ProductID { get; set; }

        public string LocationID { get; set; }

        public long? OrderDetailID { get; set; }

        public int? Quantity { get; set; }

        public Product ProductFk { get; set; }

        public Location LocationFk { get; set; }

        public ProductInventory()
        {
        }

        public ProductInventory(int? id)
        {
            ID = id;
        }
    }
}