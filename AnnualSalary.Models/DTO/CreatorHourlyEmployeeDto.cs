using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnualSalary.Models.Entities;

namespace AnnualSalary.Models.DTO
{
    public class CreatorHourlyEmployeeDto : CreatorEmployeeDto
    {
         
        public override EmployeeDto create(Employee employee)
        {
            return new HourlyEmployeeDto(employee);
        }
    }
}
