// See https://aka.ms/new-console-template for more information
using invoiceApp;
using invoiceApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
//https://andrewlock.net/using-dependency-injection-in-a-net-core-console-application/
//https://stackoverflow.com/questions/70533593/servicecollection-does-not-contain-a-definition-for-getservice
var services = new ServiceCollection();

services.AddSingleton<ILogger, Logger>();
services.AddSingleton<IInvoiceManager, InvoiceManager>();
services.AddSingleton<IInvoice, Invoice>();

var serviceProvider = services.BuildServiceProvider();
var instance = serviceProvider.GetService<IInvoiceManager>();

instance.RunInvoice();
