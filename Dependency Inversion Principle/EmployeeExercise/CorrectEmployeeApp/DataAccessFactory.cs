using CorrectEmployeeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectEmployeeApp
{
	public class DataAccessFactory
	{
		public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
		{
			return new EmployeeDataAccessLogic();
		}
	}
}
