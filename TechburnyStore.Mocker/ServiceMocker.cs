using TechburnyStore.Common.Helpers;
using TechburnyStore.Core;
using TechburnyStore.Core.Business;
using TechburnyStore.Core.Business.Contracts;

namespace TechburnyStore.Mocker
{
    public static class ServiceMocker
    {
        public static ISalesService GetSalesService()
            => new SalesService(
                LoggingHelper.GetLogger<SalesService>(),
                DbContextMocker.GetTechburnyStoreDbContext(),
                new UserInfo("mocker")
            );

        public static IWarehouseService GetWarehouseService()
            => new WarehouseService(
                LoggingHelper.GetLogger<WarehouseService>(),
                DbContextMocker.GetTechburnyStoreDbContext(),
                new UserInfo("mocker")
            );
    }
}