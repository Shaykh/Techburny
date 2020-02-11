using Microsoft.Extensions.Logging;
using TechburnyStore.Core.Business.Contracts;
using TechburnyStore.Core.Domain;

namespace TechburnyStore.Core.Business
{
    public abstract class Service : IService
    {
        protected bool Disposed;
        protected readonly ILogger Logger;

        public Service(ILogger logger, TechburnyStoreDbContext dbContext, IUserInfo userInfo)
        {
            Logger = logger;
            DbContext = dbContext;
            UserInfo = userInfo;
        }

        public void Dispose()
        {
            if (Disposed)
                return;

            DbContext?.Dispose();

            Disposed = true;
        }

        public TechburnyStoreDbContext DbContext { get; }

        public IUserInfo UserInfo { get; set; }
    }
}