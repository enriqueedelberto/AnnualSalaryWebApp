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
        private CreatorEmployeeDto[] factoryEmployee;
        private HandlerDataConnection dataConnection;

        public HandlerDataRetrieve()
        {
            this.employeesDto = new List<EmployeeDto>();
            this.factoryEmployee = new CreatorEmployeeDto[2];
            this.factoryEmployee[0] = new CreatorHourlyEmployeeDto();
            this.factoryEmployee[1] = new CreatorMonthlyEmployeeDto();
            this.dataConnection = new HandlerDataConnection();
        }


        public async Task<List<EmployeeDto>> getAllEmployeesDto()
        {
            var employees = await this.dataConnection.GetAllEmployees();

            this.employeesDto = employees.Select(emp => {

                EmployeeDto employeeDto = null;
                switch (emp.contractTypeName)
                {
                    case HOURLY_SALARY_EMPLOYEE:
                        employeeDto = this.factoryEmployee[0].createEmployee(emp);
                        break;

                    case MONTHLY_SALARY_EMPLOYEE:
                        employeeDto = this.factoryEmployee[1].createEmployee(emp);
                        break;
                }
                return employeeDto;

            }).ToList();


            return this.employeesDto;
        }
    }
}
