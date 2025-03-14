﻿// See https://aka.ms/new-console-template for more information
using InvoiceApp2;
using InvoiceApp2.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();
services.AddSingleton<IInvoiceManager, InvoiceManager>();
services.AddSingleton<IInvoice, Invoice>();
services.AddSingleton<IFinalInvoice, FinalInvoice>();
services.AddSingleton<IRecurringInvoice, RecurringInvoice>();
services.AddSingleton<IProposedInvoice, ProposedInvoice>();

var serviceProvider = services.BuildServiceProvider();
var runnerInstance = serviceProvider.GetService<IInvoiceManager>();
runnerInstance.run();
