using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOEmployee: IEmployee 
    {

        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
        public decimal AnualSalary { get; set; }

        public virtual void CalculateSalaryAnnually()
        {
            throw new NotImplementedException();
        }

    }
}
