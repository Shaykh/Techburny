using System;
using TechburnyStore.Core.Domain;

namespace TechburnyStore.Core.Business.Contracts
{
    public interface IService : IDisposable
    {
        TechburnyStoreDbContext DbContext { get; }

        IUserInfo UserInfo { get; set; }
    }
}