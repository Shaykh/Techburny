using System.Collections.Generic;
using TechburnyStore.Core.Domain.Sales;
using TechburnyStore.Core.Domain.Warehouse;

namespace TechburnyStore.Core.Business.Requests
{
    public class CreateOrderRequest : ICreateOrderRequest
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Customer> Customers { get; set; }
    }
}