using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee.Library
{
    public class EmployeeService
    {
        private IEmployeeRepository employeeRepository;

        internal EmployeeService(IEmployeeRepository employeeRepository)
        {
            // TODO: Complete member initialization
            this.employeeRepository = employeeRepository;
        }

        public bool HasValidEmployeeList(int deptId)
        {
            var result = this.employeeRepository.GetEmployees().Where(e=>e.Department ==deptId);
            if (result.Count() > 0)
                return true;

            return false;
        }
    }
}
