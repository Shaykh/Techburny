using System.Collections.ObjectModel;

namespace TechburnyStore.Core.Domain.Sales
{
    public class Shipper : AuditableEntity
    {
        public int? ID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public virtual Collection<OrderHeader> Orders { get; set; }
    }
}