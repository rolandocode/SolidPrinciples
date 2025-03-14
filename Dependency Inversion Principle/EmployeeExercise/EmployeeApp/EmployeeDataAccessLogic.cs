using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
	public class EmployeeDataAccessLogic
	{
		public Employee GetEmployeeDetails(int id)
		{
			Employee employee = new Employee()
			{
				ID = id,
				Name = "Rolando",
				Department = "R&D",
				Salary = 100000
			};
			return employee;
		}
	}
}
