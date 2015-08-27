using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee.Library.Factory
{
    public interface IEmployeeServiceFactory
    {
        EmployeeService Create(IEmployeeRepository employeeRepository);
    }
}
