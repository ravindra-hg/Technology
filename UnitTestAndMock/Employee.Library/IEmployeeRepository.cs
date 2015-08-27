using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Library
{
    public interface IEmployeeRepository
    {
        List<Modal.Emp> GetEmployees();
    }
}
