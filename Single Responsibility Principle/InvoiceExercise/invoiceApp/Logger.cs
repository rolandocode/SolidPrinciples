using invoiceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceApp
{
	public class Logger : ILogger
	{
		public Logger() 
		{
		}

		public void Info(string info)
		{
			Console.Write(info);
		}
		public void Debug(string info)
		{
			// here we need to write the Code for Debug information into the ErrorLog text file
		}
		public void Error(string message, Exception ex)
		{
			// here we need to write the Code for Error information into the ErrorLog text file
		}
	}
}
