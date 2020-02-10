namespace TechburnyStore.Core.Domain.Sales
{
    public class Customer : AuditableEntity
    {
        public int? ID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public virtual Collection<OrderHeader> Orders { get; set; }

        public Customer()
        {
        }

        public Customer(int? id)
        {
            ID = id;
        }

    }
}