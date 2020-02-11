using System.Collections.Generic;
using TechburnyStore.Core.Domain.Sales;
using TechburnyStore.Core.Domain.Warehouse;

namespace TechburnyStore.Core.Business.Requests
{
    public interface ICreateOrderRequest : IRequest
    {
         IEnumerable<Product> Products { get; set; }

        IEnumerable<Customer> Customers { get; set; }
    }
}