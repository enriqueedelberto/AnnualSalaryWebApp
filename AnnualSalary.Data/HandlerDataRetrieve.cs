using AnnualSalary.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalary.Data
{
    public class HandlerDataRetrieve
    {
        private const string HOURLY_SALARY_EMPLOYEE = "HourlySalaryEmployee";
        private const string MONTHLY_SALARY_EMPLOYEE = "MonthlySalaryEmployee";
        private List<EmployeeDto> employeesDto;
        private CreatorEmployeeDto factoryHourlyEmployee;
        private CreatorEmployeeDto factoryMonthlyEmployee;

        public HandlerDataRetrieve()
        {
            this.employeesDto = new List<EmployeeDto>(); 
            this.factoryHourlyEmployee = new CreatorHourlyEmployeeDto();
            this.factoryMonthlyEmployee = new CreatorMonthlyEmployeeDto();
            
        }


        public async Task<List<EmployeeDto>> getAllEmployeesDto()
        {
            var employees = await HandlerDataConnection.getInstance().GetAllEmployees();

            this.employeesDto = employees.Select(emp => {

                EmployeeDto employeeDto = null;
                switch (emp.contractTypeName)
                {
                    case HOURLY_SALARY_EMPLOYEE:
                        employeeDto = this.factoryHourlyEmployee.createEmployee(emp);
                        break;

                    case MONTHLY_SALARY_EMPLOYEE:
                        employeeDto = this.factoryMonthlyEmployee.createEmployee(emp);
                        break;
                }
                return employeeDto;

            }).ToList();


            return this.employeesDto;
        }
    }
}
