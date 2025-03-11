using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace invoiceApp
{
	public class Invoice
	{
		public decimal InvoiceAmount { get; set; }
		public DateTime InvoiceDate { get; set; }

		public void AddInvoice()
		{
			try
			{
				MailMessage mailMessage = new MailMessage("mail@app-mail.com", "dest@destinatary.com",
					"Subject: SRP", "EmailBody");
				this.SendInvoice(mailMessage);
			}
			catch (Exception ex)
			{

				System.IO.File.WriteAllText("ErrorLog.txt", ex.ToString());
			}
		}

		public void SendInvoice(MailMessage mailMessage)
		{
			try
			{

			}
			catch (Exception ex)
			{

				System.IO.File.WriteAllText("ErrorLog.txt", ex.ToString());
			}
		}

		public void DeleteInvoice()
		{
			try
			{
				//Here we need to write the Code for Deleting the already generated invoice
			}
			catch (Exception ex)
			{
				//Error Logging
				System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
			}
		}
	}

}
