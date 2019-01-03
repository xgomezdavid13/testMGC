using DTO;
using System;

namespace BAL
{
    public class BALEmployeeFactory
    {
        const string MONTHLYSALARYEMPLOYEE = "MonthlySalaryEmployee";
        const string HOURLYSALARYEMPLOYEE = "HourlySalaryEmployee";

        public IEmployee FindTypeEmployee(DTOEmployee employee)
        {
            switch (employee.contractTypeName)
            {
                case MONTHLYSALARYEMPLOYEE:
                    return new DTOEmployeeMonth(employee);
                case HOURLYSALARYEMPLOYEE:
                    return new DTOEmployeeHour(employee);
                default:
                    throw new ApplicationException("Salary type not found!!!");
            }
        }

    }
}
