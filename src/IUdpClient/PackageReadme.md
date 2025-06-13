## Info
This project uses source generation to generate an `IUdpClient` interface and `UdpClientProxy` from the `UdpClient` to make it injectable and unit-testable.

All the methods and properties from the `UdpClient` are replicated to `IUdpClient`.

### Usage

``` c#
using System.Net;
using System.Net.Sockets;

var udpClient = new UdpClient(Dns.GetHostName(), 0);
var udpClientProxy = new UdpClientProxy(udpClient);

udpClientProxy.Ttl = 129;

await udpClientProxy.SendAsync("hello"u8.ToArray());
```

### Sponsors

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=StefH) and [Dapper Plus](https://dapper-plus.net/?utm_source=StefH) are major sponsors and proud to contribute to the development of **IUdpClient**.

[![Entity Framework Extensions](https://raw.githubusercontent.com/StefH/resources/main/sponsor/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert?utm_source=StefH)

[![Dapper Plus](https://raw.githubusercontent.com/StefH/resources/main/sponsor/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert?utm_source=StefH)