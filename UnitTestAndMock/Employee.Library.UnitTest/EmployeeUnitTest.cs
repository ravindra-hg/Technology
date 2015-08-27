using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee.Library;
using Employee.Library.Modal;
using Employee.Library.Factory;

namespace Employee.Library.UnitTest
{
    [TestClass]
    public class EmployeeUnitTest
    {
        private IEmployeeServiceFactory factory;
        [TestInitialize()]
        public void Init()
        {
            this.factory =  new EmployeeServiceFactory();
        }

        [TestMethod]
        public void Check_Employee_Count()
        {
            //This connects to real 
            IEmployeeRepository repository = new EmployeeRepository();
            List<Emp> emp = repository.GetEmployees();
            Assert.AreEqual(3, emp.Count);
        }


        /// <summary>
        /// This is manual mocking
        /// </summary>
        [TestMethod]
        public void Check_Valid_list_In_Administration_9_Department()
        {
            int administrationDepartmentID = 9; //Administration dept

            //IEmployeeRepository realEmployeeRepository = new EmployeeRepository();//This is real repository
            IEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository(); //Mock repository

            EmployeeService empService = factory.Create(mockEmployeeRepository);
            bool isValid = empService.HasValidEmployeeList(administrationDepartmentID);
            Assert.AreEqual(true, isValid);
        }

        /// <summary>
        /// This is using Moq 
        /// </summary>
        [TestMethod]
        public void Moq_Check_Valid_list_In_IT_11_Department()
        {
            int itDepartmentId = 11; //IT dept

            var employeeList = this.MockITDepartmentEmployeeList(itDepartmentId);
            //Moq.Mock<EmployeeRepository> moqEmployeeRepository = new Moq.Mock<EmployeeRepository>(Moq.MockBehavior.Strict);//Moq using class. Note: make sure GetEmployees method marked virtual in the class
            Moq.Mock<IEmployeeRepository> moqEmployeeRepository = new Moq.Mock<IEmployeeRepository>(Moq.MockBehavior.Strict);//Moq using interface
            moqEmployeeRepository.Setup(s => s.GetEmployees()).Returns(employeeList);

            EmployeeService empService = factory.Create(moqEmployeeRepository.Object);
            bool isValid = empService.HasValidEmployeeList(itDepartmentId);

            Assert.AreEqual(true, isValid);
        }

        private List<Emp> MockITDepartmentEmployeeList(int itDepartmentId)
        {
            return new List<Emp>() { new Emp() { Id = 200, Department = itDepartmentId }, new Emp() { Id = 2001, Department = itDepartmentId } };
        }
    }
}
