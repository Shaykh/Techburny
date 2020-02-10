using System;

namespace TechburnyStore.Core.Domain.Sales
{
    public class OrderSummary
    {
        public int? OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public string CustomerName { get; set; }

        public string EmployeeName { get; set; }

        public string ShipperName { get; set; }

        public int? OrderLines { get; set; }
    }
}