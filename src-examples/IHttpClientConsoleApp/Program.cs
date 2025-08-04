using System;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection;

var httpClient = new HttpClient();
var httpClientProxy = new HttpClientProxy(httpClient);

var result = await httpClientProxy.GetAsync("https://www.google.nl");
var todo = await httpClientProxy.GetFromJsonAsync<Todo>("https://jsonplaceholder.typicode.com/todos/1");
var postResult = await httpClientProxy.PostAsJsonAsync("https://jsonplaceholder.typicode.com/todos", new Todo { Id = 123 });
var patchResult = await httpClientProxy.PatchAsJsonAsync("https://jsonplaceholder.typicode.com/todos/1", new Todo { Id = 400 });
var putResult = await httpClientProxy.PutAsJsonAsync("https://jsonplaceholder.typicode.com/todos/1", new Todo { Id = 444 });

IServiceCollection services = new ServiceCollection();
services.AddHttpClient();
services.AddSingleton<IIHttpClientFactory, HttpClientFactoryService>();

var sp = services.BuildServiceProvider();

IHttpClient myClient = sp
    .GetRequiredService<IIHttpClientFactory>()
    .CreateClient("MyClient");
var todo2 = await myClient.GetFromJsonAsync<Todo>("https://jsonplaceholder.typicode.com/todos/1");
Console.WriteLine($"Todo: {todo?.Id}");