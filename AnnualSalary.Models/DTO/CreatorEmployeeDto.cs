using AnnualSalary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalary.Models.DTO
{
    public abstract class CreatorEmployeeDto
    {
        public abstract EmployeeDto create(Employee employee);
    }
}
