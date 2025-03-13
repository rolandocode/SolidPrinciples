using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectPrinterApp.Interfaces
{
	public class PrinterManager
	{
		private IHPLaserJetPrinter _printer;
		public PrinterManager(IHPLaserJetPrinter printer)
		{
			_printer = printer;
		}

		public void run()
		{
			_printer.PrintDuplex("Duplex");
		}
	}
}
