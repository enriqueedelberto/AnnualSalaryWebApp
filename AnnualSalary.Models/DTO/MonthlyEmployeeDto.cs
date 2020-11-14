using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalary.Models.DTO
{
    public class MonthlyEmployeeDto : EmployeeDto
    {
        public override decimal calculateSalary()
        {
            return   this.monthlySalary * 12;
        }
    }
}
