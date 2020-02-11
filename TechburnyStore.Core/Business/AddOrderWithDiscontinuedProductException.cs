namespace TechburnyStore.Core.Business
{
    public class AddOrderWithDiscontinuedProductException : TechburnyStoreException
    {
        public AddOrderWithDiscontinuedProductException() : base()
        {
        }

        public AddOrderWithDiscontinuedProductException(string message) : base(message)
        {
        }
    }
}