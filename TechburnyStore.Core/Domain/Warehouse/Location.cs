using System.Collections.ObjectModel;

namespace TechburnyStore.Core.Domain.Warehouse
{
    public class Location : AuditableEntity
    {
        public string ID { get; set; }

        public string LocationName { get; set; }

        public Collection<ProductInventory> ProductInventories { get; set; }
    }
}