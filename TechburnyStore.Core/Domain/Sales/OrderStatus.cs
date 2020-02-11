using System;
using System.Collections.ObjectModel;

namespace TechburnyStore.Core.Domain.Sales
{
    public class OrderStatus : IAuditableEntity
    {
        public short? ID { get; set; }

        public string Description { get; set; }

        public string  CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string  LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }

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