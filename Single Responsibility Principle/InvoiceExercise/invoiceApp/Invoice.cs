using invoiceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace invoiceApp
{
	public class Invoice : IInvoice
	{
		public decimal InvoiceAmount { get; set; }
		public DateTime InvoiceDate { get; set; }
		private ILogger _fileLogger;
		private MailSender _mailSender { get; set; }

		public Invoice(ILogger fileLogger)
		{
			_fileLogger = fileLogger;
			_mailSender = new MailSender();
		}

		public void AddInvoice()
		{
			try
			{
				_fileLogger.Info("Add method Start");
				// Here we need to write the Code for adding invoice
				// Once the Invoice has been added, then send the  mail
				_mailSender.EMailFrom = "emailfrom@xyz.com";
				_mailSender.EMailTo = "emailto@xyz.com";
				_mailSender.EMailSubject = "Single Responsibility Princile";
				_mailSender.EMailBody = "A class should have only one reason to change";
				_mailSender.SendEmail();
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
				_fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
			}
			catch (Exception ex)
			{
				//Error Logging
				_fileLogger.Error("Error Occurred while Deleting Invoice", ex);
			}
		}
	}

}
