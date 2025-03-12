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
		public InvoiceManager(ILogger logger)
		{
			_logger = logger;
		}

		public void RunInvoice()
		{
			_logger.Info("it´s all good man!");
		}
	}
}
