﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceApp
{
	public class MailSender
	{
		public string EMailFrom { get; set; }
		public string EMailTo { get; set; }
		public string EMailSubject { get; set; }
		public string EMailBody { get; set; }
		public void SendEmail()
		{
			// Here we need to write the Code for sending the mail
			Console.WriteLine("Sending email to..." +EMailTo);
			Console.WriteLine("SUCCEED!" + EMailTo);

		}
	}
}
