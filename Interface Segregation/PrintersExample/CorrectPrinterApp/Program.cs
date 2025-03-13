// See https://aka.ms/new-console-template for more information
using CorrectPrinterApp;
using CorrectPrinterApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();

services.AddScoped<IHPLaserJetPrinter, HPLaserJetPrinter>();
services.AddScoped< PrinterManager>();


var serviceBuild =  services.BuildServiceProvider();
var printerInstance = serviceBuild.GetService<IHPLaserJetPrinter>();

//Now, you can see the LiquidInkjetPrinter class is not implementing the Fax and PrintDuplex methods 
//	as these services are not required by the LiquidInkjetPrinter class. 
//	That means now our application design follows the Interface Segregation Principle.
//	Now, you can test the functionality of the two classes by modifying the Program class code as 
//	follows.
printerInstance.Fax("Content fax");
printerInstance.Print("Content print");
printerInstance.PrintDuplex("Content duplex");
printerInstance.Scan("Content scan");

Console.WriteLine("============================================");

var manager = serviceBuild.GetService<PrinterManager>();
manager.run();
