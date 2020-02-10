using System;

namespace TechburnyStore.Core.Domain.Sales
{
    public class PaymentMethod : AuditableEntity
    {
        public Guid? ID { get; set; }

        public string PaymentMethodName { get; set; }

        public string PaymentMethodDescription { get; set; }
    }
}