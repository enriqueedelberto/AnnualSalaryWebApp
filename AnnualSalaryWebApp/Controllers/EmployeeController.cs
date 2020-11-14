using AnnualSalary.Data;
using AnnualSalary.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AnnualSalaryWebApp.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {

        // GET: api/Employee
        [HttpGet]
        [Route("GetEmployees")]
        public async Task<List<EmployeeDto>> GetAll()
        {
            var dataConnection = new HandlerDataRetrieve();
            List<EmployeeDto> employeesDto = await dataConnection.getAllEmployeesDto();
            return employeesDto;
        }

        // GET: api/Employee/5
        [HttpGet]
        [Route("GetEmployee")]
        public async Task<EmployeeDto> GetEmployee([FromUri] string id)
        {
            var dataConnection = new HandlerDataRetrieve();
            List<EmployeeDto> employeesDto = await dataConnection.getAllEmployeesDto();

            return employeesDto.FirstOrDefault(emp=> emp.id.Equals(id));
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
