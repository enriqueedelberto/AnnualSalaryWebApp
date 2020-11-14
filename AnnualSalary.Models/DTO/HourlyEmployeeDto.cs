using AnnualSalary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalary.Models.DTO
{
    public class HourlyEmployeeDto : EmployeeDto
    {

        public HourlyEmployeeDto(Employee employee)
        {

            this.id = employee.id;
            this.name = employee.name;
            this.contractTypeName = employee.contractTypeName;
            this.roleId = employee.roleId;
            this.roleName = employee.roleName;
            this.roleDescription = employee.roleName;
            this.hourlySalary = employee.hourlySalary;
            this.monthlySalary = employee.monthlySalary;
        }

        public override decimal annualSalary {

            get => 120 * this.hourlySalary * 12;

        }

        public override decimal calculateSalary()
        {
            return 120 * this.hourlySalary * 12;
        }
    }
}
