using System.Security.Cryptography;
using Terminology.WebHost.Extensions.HostBuilder;

var builder = WebApplication.CreateBuilder(args);

builder.Host.AddSerilog();

var app = builder.Build();

Oid oid = new Oid("1.2.643.5.1.13.13.12.3.23.131446");
Console.WriteLine(oid.Value);

app.Run();