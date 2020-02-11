namespace TechburnyStore.Core.Business
{
    public class DuplicatedProductNameException : TechburnyStoreException
    {
        public DuplicatedProductNameException() : base()
        {
        }

        public DuplicatedProductNameException(string message) : base(message)
        {
        }
    }
}