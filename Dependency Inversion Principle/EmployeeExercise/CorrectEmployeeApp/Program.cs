// See https://aka.ms/new-console-template for more information
using CorrectEmployeeApp;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");


var services = new ServiceCollection();

services.AddScoped<EmployeeBusinessLogic>();

var buildServices = services.BuildServiceProvider();

var employeeBL = buildServices.GetService<EmployeeBusinessLogic>();

employeeBL.GetEmployeeDetails(12);