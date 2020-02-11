using System;

namespace TechburnyStore.Core.Business
{
    public class TechburnyStoreException : Exception
    {
        public TechburnyStoreException() : base()
        {
        }

        public TechburnyStoreException(string message) : base(message)
        {
        }
    }
}