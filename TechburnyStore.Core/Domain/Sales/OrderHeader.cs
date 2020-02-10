using System;
using System.Collections.ObjectModel;
using TechburnyStore.Core.Domain.Dbo;
using TechburnyStore.Core.Domain.HumanResources;

namespace TechburnyStore.Core.Domain.Sales
{
    public class OrderHeader : AuditableEntity
    {
        public long? ID { get; set; }

        public short? OrderStatusID { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public int? ShipperID { get; set; }

        public decimal? Total { get; set; }

        public string CurrencyID { get; set; }

        public Guid? PaymentMethodID { get; set; }

        public int? DetailsCount { get; set; }

        public long? ReferenceOrderID { get; set; }

        public string Comments { get; set; }

        public virtual OrderStatus OrderStatusFk { get; set; }

        public virtual Customer CustomerFk { get; set; }

        public virtual Employee EmployeeFk { get; set; }

        public virtual Shipper ShipperFk { get; set; }

        public virtual Currency CurrencyFk { get; set; }

        public virtual PaymentMethod PaymentMethodFk { get; set; }

        public virtual Collection<OrderDetail> OrderDetails { get; set; }

        public OrderHeader()
        {
        }

        public OrderHeader(long? id)
        {
            ID = id;
        }
    }
}