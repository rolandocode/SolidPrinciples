using CorectFruitExample;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

Console.WriteLine("Hello there!");

var services = new ServiceCollection();

//Not necesary because you cannot instanciate an interface
//services.AddTransient<IFruit>();
services.AddTransient<Apple>();
services.AddTransient<Orange>();
services.AddTransient<FruitManager>();

var serviceInstances = services.BuildServiceProvider();

IFruit appleInstance = serviceInstances.GetService<Apple>();
Console.WriteLine("Fruit color: "+ appleInstance.GetColor());
Console.WriteLine("===========================================");

var managerInstance = serviceInstances.GetService<FruitManager>();
managerInstance.run();
Console.WriteLine("===========================================");

IFruit appleLocalInstance = new Apple();
Console.WriteLine(appleLocalInstance.GetColor());

