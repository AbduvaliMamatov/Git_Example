using Git_Example;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IService, Service>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();