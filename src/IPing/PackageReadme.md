## Info
This project uses source generation to generate an `IPing` interface and `PingProxy` from the `Ping` class to make it injectable and unit-testable.

All the methods and properties from the `Ping` class are replicated to `IPing`.

### Usage

``` c#
using System;
using System.Net.NetworkInformation;

var pingProxy = new PingProxy(new Ping());

var reply = await pingProxy.SendPingAsync("localhost", TimeSpan.FromSeconds(1));
Console.WriteLine(reply.Status);
```

### Sponsors

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=StefH) and [Dapper Plus](https://dapper-plus.net/?utm_source=StefH) are major sponsors and proud to contribute to the development of **IPing**.

[![Entity Framework Extensions](https://raw.githubusercontent.com/StefH/resources/main/sponsor/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert?utm_source=StefH)

[![Dapper Plus](https://raw.githubusercontent.com/StefH/resources/main/sponsor/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert?utm_source=StefH)