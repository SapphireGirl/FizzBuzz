using FizzBuzz.Core.Models;
using FizzBuzz.Core.Repositories;
using FizzBuzz.Core.Repositories.EntityFramework;
using FizzBuzz.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddLogging();

app.MapGet("/", () => "Hello World!");

// Add services to the container.

builder.Services.RegisterRepos();
builder.Services.RegisterLogging();

// Add Registration to the Container

builder.Services.AddTransient<IRepository, EFRepository>();



app.Run();

// Run FizzBuzz and get string

FbModel fb = new FbModel();

var mystring = fb.RunFizzBuzz();
Console.WriteLine(mystring);


