using AnnualSalary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalary.Models.DTO
{
    public abstract class EmployeeDto
    {
         

        protected string id { get; set; }
        protected string name { get; set; }
        protected string contractTypeName { get; set; }
        protected string roleId { get; set; }
        protected string roleName { get; set; }
        protected string roleDescription { get; set; }
        protected decimal hourlySalary { get; set; }
        protected decimal monthlySalary { get; set; }
        public abstract decimal annualSalary { get;  }

        public abstract decimal calculateSalary();
    }
}
