namespace TechburnyStore.Core.Domain.Warehouse
{
    public class ProductUnitPrice : AuditableEntity
    {
        public int? ID { get; set; }

        public int? ProductID { get; set; }

        public decimal? UnitPrice { get; set; }

        public ProductUnitPrice()
        {
        }

        public ProductUnitPrice(int? id)
        {
            ID = id;
        }
    }
}