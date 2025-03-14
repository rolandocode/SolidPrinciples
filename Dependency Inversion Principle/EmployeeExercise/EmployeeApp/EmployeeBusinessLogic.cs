using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
	public class EmployeeBusinessLogic
	{
		EmployeeDataAccessLogic _employeeDataAccessLogic;

		public EmployeeBusinessLogic()
		{
			_employeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
		}

		public Employee GetEmployeeDetails(int id)
		{
			return _employeeDataAccessLogic.GetEmployeeDetails(id);
		}
	}
}
