## Info
This project uses source generation to generate an `IUdpClient` interface and `UdpClientProxy` from the `UdpClient` to make it injectable and unit-testable.

All the methods and properties from the `UdpClient` are replicated to `IUdpClient`.

## Usage
``` c#
using System.Net;
using System.Net.Sockets;

var udpClient = new UdpClient(Dns.GetHostName(), 0);
var udpClientProxy = new UdpClientProxy(udpClient);

udpClientProxy.Ttl = 129;

await udpClientProxy.SendAsync("hello"u8.ToArray());
```