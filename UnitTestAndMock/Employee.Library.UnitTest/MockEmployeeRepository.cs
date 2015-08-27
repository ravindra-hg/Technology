using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employee.Library.Modal;

namespace Employee.Library.UnitTest
{
    public class MockEmployeeRepository:IEmployeeRepository
    {
        public List<Modal.Emp> GetEmployees()
        {
            return new List<Modal.Emp>() { new Emp() { Id = 100, Department = 9 } }.Where(l => l.Department == 9).ToList();
        }
    }
}
