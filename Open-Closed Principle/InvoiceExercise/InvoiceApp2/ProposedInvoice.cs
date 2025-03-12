﻿using InvoiceApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp2
{
	public class ProposedInvoice : Invoice, IProposedInvoice
	{
		public override double GetInvoiceDiscount(double amount)
		{
			return base.GetInvoiceDiscount(amount) - 40;
		}
	}
}
