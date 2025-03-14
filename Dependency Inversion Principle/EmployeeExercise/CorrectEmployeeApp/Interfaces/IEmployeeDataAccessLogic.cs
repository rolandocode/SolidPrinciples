using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectEmployeeApp.Interfaces
{
    public interface IEmployeeDataAccessLogic
    {
        Employee GetEmployeeDetails(int id);
    }
}
