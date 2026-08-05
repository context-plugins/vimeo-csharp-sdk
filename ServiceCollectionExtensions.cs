using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace VimeoApi;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddVimeoApiClient(Action<VimeoApiClientOptions>? configure = null)
        {
            var options = new VimeoApiClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddSingleton(sp =>
                {
                    options.Logging =
                        options.Logging with
                        {
                            LoggerFactory = options.Logging.LoggerFactory ?? sp.GetService<ILoggerFactory>()
                        };
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new VimeoApiClient(httpClient, options);
                });
            return services;
        }
    }
}
