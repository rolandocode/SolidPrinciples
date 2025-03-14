// See https://aka.ms/new-console-template for more information
using EmployeeApp;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();

services.AddTransient<EmployeeBusinessLogic>();

var servicesBuild = services.BuildServiceProvider();

var empBL = servicesBuild.GetService<EmployeeBusinessLogic>();

var employee = empBL.GetEmployeeDetails(12);

Console.WriteLine(employee);