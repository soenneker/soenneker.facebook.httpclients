using Soenneker.Facebook.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Facebook.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FacebookOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IFacebookOpenApiHttpClient _httpclient;

    public FacebookOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IFacebookOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
