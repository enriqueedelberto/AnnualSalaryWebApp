using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnualSalary.Models.Entities;

namespace AnnualSalary.Models.DTO
{
    public class CreatorMonthlyEmployeeDto : CreatorEmployeeDto
    {
         

        public override EmployeeDto createEmployee(Employee employee)
        {
            return new MonthlyEmployeeDto(employee);
        }
    }
}
