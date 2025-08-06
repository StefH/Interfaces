namespace System.Net.Http;

/// <inheritdoc />
public class HttpClientFactoryService(IHttpClientFactory factory) : IIHttpClientFactory
{
    /// <inheritdoc />
    public IHttpClient CreateClient(string name)
    {
        return new HttpClientProxy(factory.CreateClient(name));
    }

    /// <inheritdoc />
    public IHttpClient CreateClient()
    {
        return CreateClient(string.Empty);
    }
}