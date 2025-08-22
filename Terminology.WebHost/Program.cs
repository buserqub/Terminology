using Terminology.Infra.PostgreSql;
using Terminology.Infra.PostgreSql.Extensions;
using Terminology.WebHost.Extensions.HostBuilder;
using Terminology.WebHost.Extensions.ServiceCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.AddSerilog();

builder.Services.AddControllers();
//builder.Services.AddSwagger(builder.Configuration);

//builder.Services.AddDomainLayer(builder.Configuration);
//builder.Services.AddAppLayer(builder.Configuration);
builder.Services.AddPostgreSqlInfraLayer(builder.Configuration);

var app = builder.Build();

app.Services.ApplyMigrations();

app.Run();