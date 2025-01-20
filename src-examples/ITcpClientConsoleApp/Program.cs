using System.Linq;
using System.Net;
using System.Net.Sockets;

var tcpClient = new TcpClient();
var tcpClientProxy = new TcpClientProxy(tcpClient);

tcpClientProxy.SendTimeout = 123;

var hostName = Dns.GetHostName();
var address = Dns.GetHostAddresses(hostName).First(a => a.AddressFamily == AddressFamily.InterNetwork);
await tcpClientProxy.ConnectAsync(address, 80);