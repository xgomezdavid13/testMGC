namespace DTO
{
    public class DTOEmployeeHour : DTOEmployee
    {

        public DTOEmployeeHour()
        {

        }

        public DTOEmployeeHour(DTOEmployee employee)
        {
            this.id = employee.id;
            this.name = employee.name;
            this.contractTypeName = employee.contractTypeName;
            this.roleName = employee.roleName;
            this.hourlySalary = employee.hourlySalary;
            this.monthlySalary = employee.monthlySalary;
        }

        public override void CalculateSalaryAnnually()
        {
            this.AnualSalary = 120 * hourlySalary * 12;
        }
    }
}
