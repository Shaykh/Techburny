namespace TechburnyStore.Core.Business
{
    public class InvalidQuantityException : TechburnyStoreException
    {
        public InvalidQuantityException() : base()
        {
        }

        public InvalidQuantityException(string message) : base(message)
        {
        }
    }
}