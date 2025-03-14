using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApp.Interfaces
{
	public interface IPrinterTasks
	{
		void Print(string PrintContent);
		void Scan(string ScanContent);
		void Fax(string FaxContent);
		void PrintDuplex(string PrintDuplexContent);
	}
}
