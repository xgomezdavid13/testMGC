using SAL;
using DTO;
using System.Collections.Generic;

namespace BAL
{
    public class BALEmployeeBuilder
    {

        private List<DTOEmployee> employeeList { get; set; }

        public List<IEmployee> CalculateSalaryEmployee(int IdEmployee)
        {
            // TODO: Move it to Webconfig or another cypher file.
            string URLAPI = "http://masglobaltestapi.azurewebsites.net/api/Employees";

            SALService apiService = new SALService(URLAPI);

            //ISALEntity salEmployee = new SALDALEmployee ();
            ISALEntity salEmployee = new SALEmployee(apiService);

            BALEmployee buEmployee = new BALEmployee(salEmployee);
            employeeList = buEmployee.SearchEmployees(IdEmployee);
            return buEmployee.CalculateSalary(employeeList);
        }
    }
}
