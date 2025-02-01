## Info
This project uses source generation to generate an `IPing` interface and `PingProxy` from the `Ping` class to make it injectable and unit-testable.

All the methods and properties from the `Ping` class are replicated to `IPing`.

## Usage
``` c#
using System;
using System.Net.NetworkInformation;

var pingProxy = new PingProxy(new Ping());

var reply = await pingProxy.SendPingAsync("localhost", TimeSpan.FromSeconds(1));
Console.WriteLine(reply.Status);
```