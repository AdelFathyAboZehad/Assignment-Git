using Application.Contracts;
using Application.Features.ShoppingMethods.Commands.CreateShoppingMethod;
using Application.Features.ShoppingMethods.Queries.GetAllShoppingMethods;
using DbContextL;
using Domian;
using FluentValidation;
using InfraStructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Dbconnectionstring")));

builder.Services.AddMediatR(config =>
{ config.RegisterServicesFromAssembly(typeof(GetAllShoppingMethodsHandler).Assembly); });


builder.Services.AddValidatorsFromAssembly(typeof(GetAllShoppingMethodsHandler).Assembly);

builder.Services.AddScoped<IShoppingMethodRepository, ShoppingMethodRepository>();


//"Data Source=DESKTOP-ONV4S7L;Initial Catalog=ASPDB;Integrated Security=True;MultipleActiveResultSets=True;encrypt=false"));
//builder.Configuration.GetConnectionString("Dbconnectionstring")));

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
