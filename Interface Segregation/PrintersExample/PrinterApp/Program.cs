// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using PrinterApp;
using PrinterApp.Interfaces;

Console.WriteLine("Hello, World!");


var services = new ServiceCollection();

services.AddTransient<IPrinterTasks, HPLaserJetPrinter>();
services.AddTransient<IPrinterTasks, LiquidInkjetPrinter>();
services.AddTransient<PrinterManager>();

var servicesBuild = services.BuildServiceProvider();

var manager = servicesBuild.GetService<PrinterManager>();
manager.run();
