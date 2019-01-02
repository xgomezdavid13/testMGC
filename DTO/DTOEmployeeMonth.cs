namespace DTO
{
    public class DTOEmployeeMonth : DTOEmployee
    {
        public DTOEmployeeMonth()
        {
        }


        public DTOEmployeeMonth(DTOEmployee employee)
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
            this.AnualSalary = monthlySalary * 12;
        }
    }
}
