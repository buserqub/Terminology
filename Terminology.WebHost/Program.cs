using Terminology.WebHost.Extensions.HostBuilder;
using Terminology.WebHost.Extensions.ServiceCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.AddSerilog();

builder.Services.AddControllers();
builder.Services.AddSwagger(builder.Configuration);

var app = builder.Build();

app.Run();