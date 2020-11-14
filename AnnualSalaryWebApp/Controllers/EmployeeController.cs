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
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public Task<List<EmployeeDto>> Get()
        {
            var dataConnection = new HandlerDataRetrieve();
            return dataConnection.getAllEmployeesDto();
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
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
