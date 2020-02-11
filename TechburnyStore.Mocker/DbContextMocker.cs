using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TechburnyStore.Core.Domain;

namespace TechburnyStore.Mocker
{
    public static class DbContextMocker
    {
        private static readonly string ConnectionString;

        static DbContextMocker()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ConnectionString = configuration.GetSection("ConnectionStrings")["TechburnyStore"];
        }

        public static TechburnyStoreDbContext GetTechburnyStoreDbContext()
            => new TechburnyStoreDbContext(new DbContextOptionsBuilder<TechburnyStoreDbContext>().UseSqlServer(ConnectionString).Options);
    }
}