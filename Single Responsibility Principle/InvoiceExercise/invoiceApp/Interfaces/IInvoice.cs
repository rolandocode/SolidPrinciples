using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace invoiceApp.Interfaces
{
	public interface IInvoice
	{
		public void AddInvoice();
		public void DeleteInvoice();
		
	}
}
