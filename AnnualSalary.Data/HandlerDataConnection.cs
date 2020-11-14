using AnnualSalary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using AnnualSalary.Models.DTO;

namespace AnnualSalary.Data
{
    public class HandlerDataConnection
    {

        private string _apiUrl;
        private HttpClient client = new HttpClient();
        private const string ENDPOINT_PATH = "Employees";
        private const string HOURLY_SALARY_EMPLOYEE = "HourlySalaryEmployee";
        private const string MONTHLY_SALARY_EMPLOYEE = "MonthlySalaryEmployee";
        private List<EmployeeDto> employeesDto;
        private CreatorEmployeeDto[] factoryEmployee; 

        public HandlerDataConnection()
        {
          
            this._apiUrl = ConfigurationManager.AppSettings["Url_API_Repository"].ToString();
            this.client.BaseAddress = new Uri(this._apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            this.employeesDto = new List<EmployeeDto>();
            this.factoryEmployee = new CreatorEmployeeDto[2];
            this.factoryEmployee[0] = new CreatorHourlyEmployeeDto();
            this.factoryEmployee[1] = new CreatorMonthlyEmployeeDto();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            
            HttpResponseMessage response = await client.GetAsync(ENDPOINT_PATH);
            var employees = new List<Employee>();

            if (response.IsSuccessStatusCode)
            {
                employees = await response.Content.ReadAsAsync<List<Employee>>();
            }

            return employees;
        }

        public async Task<List<EmployeeDto>> getAllEmployeesDto()
        {
            var employees = await this.GetAllEmployees();

            this.employeesDto = employees.Select( emp => {

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
