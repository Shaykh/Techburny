using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TechburnyStore.Common.Helpers
{
    public static class LoggingHelper
    {
        public static ILogger<TModel> GetLogger<TModel>()
            => new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider()
                .GetService<ILoggerFactory>()
                .CreateLogger<TModel>();
    }
}