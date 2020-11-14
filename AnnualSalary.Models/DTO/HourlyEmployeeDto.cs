using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalary.Models.DTO
{
    public class HourlyEmployeeDto : EmployeeDto
    {
        public override decimal calculateSalary()
        {
            return 120 * this.hourlySalary * 12;
        }
    }
}
