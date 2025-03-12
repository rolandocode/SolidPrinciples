using invoiceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceApp
{
	public class InvoiceManager : IInvoiceManager
	{
		private ILogger _logger;
		private IInvoice _invoice;
		public InvoiceManager(ILogger logger, IInvoice invoice)
		{
			_logger = logger;
			_invoice = invoice;	
		}

		public void RunInvoice()
		{
			_logger.Info("it´s all good man!");
			_invoice.AddInvoice();

		}
	}
}
