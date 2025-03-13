using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectPrinterApp.Interfaces
{
	public interface IHPLaserJetPrinter : IFaxTasks, IPrintDuplexTasks, IPrinterTasks
	{
		//These definitions are not longer necessary because we are implementing the other interfaces
		//	righ here.

		//public void Print(string PrintContent);
		//public void Scan(string ScanContent);
		//public void Fax(string FaxContent);
		//public void PrintDuplex(string PrintDuplexContent);
	}
}
