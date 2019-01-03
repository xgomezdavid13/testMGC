using SAL;
using DTO;
using System.Collections.Generic;

namespace BAL
{
    public class BALEmployee
    {

        private ISALEntity EmployeeService { get; set; }
        private IEmployee Employee { get; set; }
        private IList<DTOEmployee> EmployeesList { get; set; }

        public BALEmployee(ISALEntity salEmployee)
        {
            EmployeeService = salEmployee;
        }

        public BALEmployee()
        {

        }

        public List<DTOEmployee> SearchEmployees(int idEmployee)
        {
            List<DTOEmployee> employeesTmp = EmployeeService.SearchEntity();
            List<DTOEmployee> employees = new List<DTOEmployee>();

            if (idEmployee != -1)
            {
                if (employeesTmp.Find(x => x.id == idEmployee) == null)
                {
                    throw new System.NullReferenceException();
                }

                employees.Add(employeesTmp.Find(x => x.id == idEmployee));
                return employees;
            }
            else
            {
                return employeesTmp;
            }
        }

        public List<IEmployee> CalculateSalary(List<DTOEmployee> EmployeeList)
        {
            List<IEmployee> employeeCalculated = new List<IEmployee>();
            BAL.BALEmployeeFactory buEmployeeFactory = new BAL.BALEmployeeFactory();

            foreach (DTOEmployee element in EmployeeList)
            {
                IEmployee employee = buEmployeeFactory.FindTypeEmployee(element);
                employee.CalculateSalaryAnnually();
                employeeCalculated.Add(employee);
            }
            return employeeCalculated;
        }
    }
}
