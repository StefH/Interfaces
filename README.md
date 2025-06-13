# ![Icon](./resources/interfaces-icon_32x32.png) Info
This project uses source generation to generate interfaces and proxy-classes to facilitate dependency injection and better unit-testability.

# Supported classes

## ➡️ HttpClient
This project uses source generation to generate an `IHttpClient` interface and `HttpClientProxy` from the `System.Net.Http.HttpClient` class.

All the methods and properties from the `HttpClient` class are replicated to a generated `IHttpClient`. And a generated `HttpClientProxy` wraps the `HttpClient` class.

### NuGet
[![NuGet Badge](https://img.shields.io/nuget/v/IHttpClient)](https://www.nuget.org/packages/IHttpClient)

### Usage
``` c#
var httpClient = new HttpClient();
IHttpClient httpClientProxy = new HttpClientProxy(httpClient); 

var result = await httpClientProxy.GetAsync("https://www.google.nl");
var todo = await httpClientProxy.GetFromJsonAsync<Todo>("https://jsonplaceholder.typicode.com/todos/1");
var postResult = await httpClientProxy.PostAsJsonAsync("https://jsonplaceholder.typicode.com/todos", new Todo { Id = 123 });
var patchResult = await httpClientProxy.PatchAsJsonAsync("https://jsonplaceholder.typicode.com/todos/1", new Todo { Id = 400 });
var putResult = await httpClientProxy.PutAsJsonAsync("https://jsonplaceholder.typicode.com/todos/1", new Todo { Id = 444 });
```

## ➡️ Ping
This project uses source generation to generate an `IPing` interface and `PingProxy` from the `System.Net.NetworkInformation.Ping` class.

All the methods and properties from the `Ping` class are replicated to a generated `IPing`. And a generated `PingProxy` wraps the `Ping` class.

### NuGet
[![NuGet Badge](https://img.shields.io/nuget/v/IPing)](https://www.nuget.org/packages/IPing)

### Usage
``` c#
using System;
using System.Net.NetworkInformation;

var pingProxy = new PingProxy(new Ping());

var reply = await pingProxy.SendPingAsync("localhost", TimeSpan.FromSeconds(1));
Console.WriteLine(reply.Status);
```


## ➡️ TcpClient
This project uses source generation to generate an `ITcpClient` interface and `TcpClientProxy` from the `System.Net.Sockets.TcpClient` class.

All the methods and properties from the `TcpClient` class are replicated to `ITcpClient` and a generated `TcpClientProxy` wraps the `TcpClient` class.

### NuGet
[![NuGet Badge](https://img.shields.io/nuget/v/ITcpClient)](https://www.nuget.org/packages/ITcpClient)

### Usage
``` c#
using System.Linq;
using System.Net;
using System.Net.Sockets;

var tcpClient = new TcpClient();
var tcpClientProxy = new TcpClientProxy(tcpClient);

tcpClientProxy.SendTimeout = 123;

var hostName = Dns.GetHostName();
var address = Dns.GetHostAddresses(hostName).First(a => a.AddressFamily == AddressFamily.InterNetwork);
await tcpClientProxy.ConnectAsync(address, 80);
```

## ➡️ UdpClient
This project uses source generation to generate an `IUdpClient` interface and `UdpClientProxy` from the `System.Net.Sockets.UdpClient` class.

All the methods and properties from the `UdpClient` class are replicated to `IUdpClient` and a generated `UdpClientProxy` wraps the `UdpClient` class.

### NuGet
[![NuGet Badge](https://img.shields.io/nuget/v/IUdpClient)](https://www.nuget.org/packages/IUdpClient)

### Usage
``` c#
using System.Net;
using System.Net.Sockets;

var udpClient = new UdpClient(Dns.GetHostName(), 0);
var udpClientProxy = new UdpClientProxy(udpClient);

udpClientProxy.Ttl = 129;

await udpClientProxy.SendAsync("hello"u8.ToArray());
```

## Sponsors

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=StefH) and [Dapper Plus](https://dapper-plus.net/?utm_source=StefH) are major sponsors and proud to contribute to the development of **IHttpClient**, **IPing**, **ITcpClient** and **IUdpClient**.

[![Entity Framework Extensions](https://raw.githubusercontent.com/StefH/resources/main/sponsor/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert?utm_source=StefH)

[![Dapper Plus](https://raw.githubusercontent.com/StefH/resources/main/sponsor/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert?utm_source=StefH)