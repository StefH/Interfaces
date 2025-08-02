namespace System.Net.Http;

/// <summary>
/// A factory abstraction for a component that can create <see cref="IHttpClient"/> instances with custom configuration for a given logical name.
/// </summary>
public interface IIHttpClientFactory
{
    /// <summary>
    /// Creates and configures an <see cref="IHttpClient"/> instance using the configuration that corresponds
    /// to the logical name specified by <paramref name="name"/>.
    /// </summary>
    /// <param name="name">The logical name of the client to create.</param>
    /// <returns>A new <see cref="IHttpClient"/> instance.</returns>
    /// <remarks>
    /// <para>
    /// Each call to <see cref="CreateClient(string)"/> is guaranteed to return a new <see cref="IHttpClient"/> instance.
    /// It is generally not necessary to dispose of the <see cref="IHttpClient"/> as the <see cref="IIHttpClientFactory"/> tracks and disposes resources used by the <see cref="IHttpClient"/>.
    /// </para>
    /// <para>
    /// Callers are also free to mutate the returned <see cref="HttpClient"/> instance's public properties as desired.
    /// </para>
    /// </remarks>
    IHttpClient CreateClient(string name);
}