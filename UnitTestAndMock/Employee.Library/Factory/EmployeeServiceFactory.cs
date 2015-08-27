using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee.Library.Factory
{
    public class EmployeeServiceFactory : IEmployeeServiceFactory
    {
        public EmployeeService Create(IEmployeeRepository employeeRepository)
        {
            return new EmployeeService(employeeRepository);
        }
    }
}
