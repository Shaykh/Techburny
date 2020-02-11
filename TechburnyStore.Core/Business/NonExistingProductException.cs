namespace TechburnyStore.Core.Business
{
    public class NonExistingProductException : TechburnyStoreException
    {
        public NonExistingProductException() : base()
        {
        }

        public NonExistingProductException(string  message) : base(message)
        {
        }
    }
}