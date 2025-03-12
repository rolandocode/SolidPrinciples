using InvoiceApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp2
{
	public class InvoiceManager : IInvoiceManager
	{

		private IInvoice _invoice;
        public InvoiceManager(IInvoice invoice)
        {
			_invoice = invoice;
        }
        public void run()
		{
			var invoiceAmount1 = _invoice.GetInvoiceDiscount(250, InvoiceType.FinalInvoice);
			var invoiceAmount2 = _invoice.GetInvoiceDiscount(250, InvoiceType.ProposedInvoice);
		}

	}
}
