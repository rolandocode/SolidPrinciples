// See https://aka.ms/new-console-template for more information
using FruitExample;
using FruitExample.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();
services.AddTransient<Orange>();
services.AddTransient<Apple>();
services.AddTransient<FruitManager>();


var serviceBuild = services.BuildServiceProvider();

//First way to reproduce issue: Directly instanciate in program.cs the apple asignation to orange object
Apple apple = serviceBuild.GetRequiredService<Orange>();
Console.WriteLine("Apple color from program.cs: " + apple.GetColor());
Console.WriteLine("=========================================");


//Second way to do it, create a class that handles the asingation in constructor
var manager = serviceBuild.GetService<FruitManager>();
manager.run();
Console.WriteLine("=========================================");


//Third way to do it is just like the example;
Apple appleInstance = new Orange();
Console.WriteLine(apple.GetColor());

