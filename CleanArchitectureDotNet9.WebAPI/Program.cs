using CleanArchitectureDotNet9.Application;
using CleanArchitectureDotNet9.Persistence;
using CleanArchitectureDotNet9.WebApi.Extensions;
using CleanArchitectureDotNet9.WebAPI.Endpoints;
using CleanArchitectureDotNet9.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePersistence(builder.Configuration);
builder.Services.ConfigureApplication();
builder.Services.AddSwaggerConfiguration(builder.Configuration);

builder.Services.ConfigureCorsPolicy();
builder.Services.ConfigureApiBehavior();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.SwaggerConfig(builder.Configuration, "SwaggerConfigTest");
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseErrorHandler();
app.MapUserEndpoints();

app.Run();
