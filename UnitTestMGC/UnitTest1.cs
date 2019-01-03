using Microsoft.VisualStudio.TestTools.UnitTesting;
using BAL;
using DTO;
using System.Collections.Generic;

namespace UnitTestMGC
{
    [TestClass]
    public class EmployeeTest
    {
        public DTOEmployee Employee { get; set; }

        [TestMethod]
        public void SalaryAnuallyTest()
        {
            // arrange
            this.ConfigEmployee();
            decimal anualSalary = 288000;
            List<DTOEmployee> employeesList = new List<DTOEmployee>();
            employeesList.Add(this.Employee);
            IList<IEmployee> employeesCalculated;
            BALEmployee buEmployee = new BALEmployee();

            // act
            employeesCalculated = buEmployee.CalculateSalary(employeesList);

            // Assert
            Assert.IsTrue(anualSalary == ((DTOEmployeeHour)employeesCalculated[0]).AnualSalary);

        }

        public void ConfigEmployee()
        {
            DTOEmployee dtoEmployee = new DTOEmployee { id = 1, contractTypeName = "HourlySalaryEmployee", hourlySalary = 200 };
            this.Employee = new DTOEmployeeHour(dtoEmployee);
        }
    }
}
