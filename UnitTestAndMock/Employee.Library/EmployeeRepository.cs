using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee.Library
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Modal.Emp> GetEmployees()
        {
            //Assume this data is from database
            List<Modal.Emp> employeeList = new List<Modal.Emp>() { 
                new Modal.Emp() { Id = 1,Department = 10 },
                new Modal.Emp() { Id = 2,Department = 10 },
                new Modal.Emp() { Id = 3,Department = 10 } 
            };

            //Hit the db to get employee data
            return employeeList;
        }
    }
}
