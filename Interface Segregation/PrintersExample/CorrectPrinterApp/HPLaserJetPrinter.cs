using CorrectPrinterApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectPrinterApp
{
	                                                   /*Those implementations are not longer necesary due the interface*/
	public class HPLaserJetPrinter : IHPLaserJetPrinter/*, IFaxTasks, IPrinterTasks, IPrintDuplexTasks*/
	{
		public void Print(string PrintContent)
		{
			Console.WriteLine("Print Done");
		}
		public void Scan(string ScanContent)
		{
			Console.WriteLine("Scan content");
		}
		public void Fax(string FaxContent)
		{
			Console.WriteLine("Fax content");
		}
		public void PrintDuplex(string PrintDuplexContent)
		{
			Console.WriteLine("Print Duplex content");
		}
	}
}
