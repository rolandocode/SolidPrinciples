﻿using CorrectEmployeeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectEmployeeApp
{
	public class EmployeeDataAccessLogic : IEmployeeDataAccessLogic
	{
		public Employee GetEmployeeDetails(int id)
		{
			//In real time get the employee details from database
			//but here we have hard coded the employee details
			Employee emp = new Employee()
			{
				ID = id,
				Name = "Pranaya",
				Department = "IT",
				Salary = 10000
			};
			return emp;
		}
	}
}
