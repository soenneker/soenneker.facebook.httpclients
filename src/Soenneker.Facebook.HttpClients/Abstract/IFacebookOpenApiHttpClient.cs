using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Facebook.HttpClients.Abstract;

/// <summary>
/// Provides a cached, authenticated HttpClient for the Facebook Graph API.
/// </summary>
public interface IFacebookOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the cached HTTP client using the configured access token and API base URL.
    /// </summary>
    /// <param name="cancellationToken">Token used to cancel client initialization.</param>
    /// <returns>The configured HTTP client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
