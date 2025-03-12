using InvoiceApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp2
{
	public class Invoice : IInvoice
	{
		public virtual double GetInvoiceDiscount(double amount/*, InvoiceType invoiceType*/)
		{
			return amount;

			//double finalAmount = 0;
			//if (invoiceType == InvoiceType.FinalInvoice)
			//{
			//	finalAmount = amount - 100;
			//}
			//else if (invoiceType == InvoiceType.ProposedInvoice)
			//{
			//	finalAmount = amount - 50;
			//}

			//return finalAmount;
		}
	}

	public enum InvoiceType
	{
		FinalInvoice,
		ProposedInvoice
	};
}
