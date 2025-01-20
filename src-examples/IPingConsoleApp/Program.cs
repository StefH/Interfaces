using System;
using System.Net.NetworkInformation;

var pingProxy = new PingProxy(new Ping());

var reply = await pingProxy.SendPingAsync("localhost", TimeSpan.FromSeconds(1));
Console.WriteLine(reply.Status);