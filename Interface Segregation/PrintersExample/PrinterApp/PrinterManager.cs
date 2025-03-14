using PrinterApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApp
{
	public class PrinterManager
	{
        IPrinterTasks _hpLaserJet;
        IPrinterTasks _liquidInject;
        public PrinterManager(IPrinterTasks hpLaserJet, IPrinterTasks liquidInject)
        {
            _hpLaserJet = hpLaserJet;
            _liquidInject = liquidInject;
        }

        public void run()
        {
            //This is going to mark exception because liquid inject has not the capacity to Fax content
            //So this is a bad implementation.
            _liquidInject.Fax("Memo");
        }
    }
}
