using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Facebook.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Facebook.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class FacebookOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="FacebookOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddFacebookOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IFacebookOpenApiHttpClient, FacebookOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="FacebookOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddFacebookOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IFacebookOpenApiHttpClient, FacebookOpenApiHttpClient>();

        return services;
    }
}
