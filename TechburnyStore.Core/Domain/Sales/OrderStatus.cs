using System.Collections.ObjectModel;

namespace TechburnyStore.Core.Domain.Sales
{
    public class OrderStatus : AuditableEntity
    {
        public short? ID { get; set; }

        public string Description { get; set; }

        public virtual Collection<OrderHeader> Orders { get; set; }

        public OrderStatus()
        {
        }

        public OrderStatus(short? id)
        {
            ID = id;
        }
    }
}