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
		private IFinalInvoice _finalInvoice;
		private IProposedInvoice _proposedInvoice;
		private IRecurringInvoice _recurringInvoice;
        public InvoiceManager(IInvoice invoice, IFinalInvoice finalInvoice, 
			IProposedInvoice proposedInvoice, IRecurringInvoice recurringInvoice)
        {
			_invoice = invoice;
			_finalInvoice = finalInvoice;
			_proposedInvoice = proposedInvoice;
			_recurringInvoice = recurringInvoice;
        }
        public void run()
		{
			//var invoiceAmount1 = _invoice.GetInvoiceDiscount(250, InvoiceType.FinalInvoice);
			//var invoiceAmount2 = _invoice.GetInvoiceDiscount(250, InvoiceType.ProposedInvoice);

			var invoiceAmount1 = _finalInvoice.GetInvoiceDiscount(250);
			var invoiceAmount2 = _proposedInvoice.GetInvoiceDiscount(250);
			var invoiceAmount3 = _recurringInvoice.GetInvoiceDiscount(250);
		}

	}
}
