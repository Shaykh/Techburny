using System;
using System.Collections.ObjectModel;

namespace TechburnyStore.Core.Domain.Warehouse
{
    public class Location : IAuditableEntity
    {
        public string ID { get; set; }

        public string LocationName { get; set; }

        public string  CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string  LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }

        public Collection<ProductInventory> ProductInventories { get; set; }
    }
}