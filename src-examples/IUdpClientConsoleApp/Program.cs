using System.Net;
using System.Net.Sockets;

var udpClient = new UdpClient(Dns.GetHostName(), 0);
var udpClientProxy = new UdpClientProxy(udpClient);

udpClientProxy.Ttl = 129;

await udpClientProxy.SendAsync("hello"u8.ToArray());