// See https://aka.ms/new-console-template for more information
using invoiceApp;
using invoiceApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");


var services = new ServiceCollection();

services.AddSingleton<ILogger, Logger>();
services.AddSingleton<IInvoiceManager, InvoiceManager>();

var serviceProvider = services.BuildServiceProvider();

var instance = serviceProvider.GetService<IInvoiceManager>();

instance.RunInvoice();
