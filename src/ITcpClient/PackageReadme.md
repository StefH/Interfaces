## Info
This project uses source generation to generate an `ITcpClient` interface and `TcpClientProxy` from the `TcpClient` to make it injectable and unit-testable.

All the methods and properties from the `TcpClient` are replicated to `ITcpClient`.

## Usage
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