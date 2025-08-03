## Info
This project uses source generation to generate an `IHttpClient` interface and `HttpClientProxy` from the `HttpClient` to make it injectable and unit-testable.

All the methods and properties from the `HttpClient` are replicated to `IHttpClient`.

### Usage
Use it direct:

``` c#
HttpClient httpClient = new HttpClient();
IHttpClient httpClientProxy = new HttpClientProxy(httpClient);

var result = await httpClientProxy.GetAsync("https://www.google.nl");
var todo = await httpClientProxy.GetFromJsonAsync<Todo>("https://jsonplaceholder.typicode.com/todos/1");
var postResult = await httpClientProxy.PostAsJsonAsync("https://jsonplaceholder.typicode.com/todos", new Todo { Id = 123 });
var patchResult = await httpClientProxy.PatchAsJsonAsync("https://jsonplaceholder.typicode.com/todos/1", new Todo { Id = 400 });
var putResult = await httpClientProxy.PutAsJsonAsync("https://jsonplaceholder.typicode.com/todos/1", new Todo { Id = 444 });
```

Or use the `IIHttpClientFactory` to create the `IHttpClient`:

``` c#
IServiceCollection services = new ServiceCollection();
services.AddHttpClient();
services.AddSingleton<IIHttpClientFactory, HttpClientFactoryService>();

IHttpClient httpClientProxy = services.BuildServiceProvider()
	.GetRequiredService<IIHttpClientFactory>()
	.Create("MyClient");
```

### Sponsors

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=StefH) and [Dapper Plus](https://dapper-plus.net/?utm_source=StefH) are major sponsors and proud to contribute to the development of **IHttpClient**.

[![Entity Framework Extensions](https://raw.githubusercontent.com/StefH/resources/main/sponsor/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert?utm_source=StefH)

[![Dapper Plus](https://raw.githubusercontent.com/StefH/resources/main/sponsor/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert?utm_source=StefH)