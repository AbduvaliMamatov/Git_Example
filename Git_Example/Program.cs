using Git_Example.Data;
using Git_Example.Repositories;
using Git_Example.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GitContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddControllers();
builder.Services.AddScoped<IGitRepository, GitRepository>();

var app = builder.Build();
app.Run();