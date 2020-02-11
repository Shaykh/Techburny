namespace TechburnyStore.Core.Business
{
    public class ForeignKeyDependencyException : TechburnyStoreException
    {
        public ForeignKeyDependencyException() : base()
        {
        }

        public ForeignKeyDependencyException(string  message) : base(message)
        {
        }
    }
}