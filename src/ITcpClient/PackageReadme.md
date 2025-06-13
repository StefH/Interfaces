## Info
This project uses source generation to generate an `ITcpClient` interface and `TcpClientProxy` from the `TcpClient` to make it injectable and unit-testable.

All the methods and properties from the `TcpClient` are replicated to `ITcpClient`.

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

### Sponsors

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=StefH) and [Dapper Plus](https://dapper-plus.net/?utm_source=StefH) are major sponsors and proud to contribute to the development of **ITcpClient**.

[![Entity Framework Extensions](https://raw.githubusercontent.com/StefH/resources/main/sponsor/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert?utm_source=StefH)

[![Dapper Plus](https://raw.githubusercontent.com/StefH/resources/main/sponsor/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert?utm_source=StefH)