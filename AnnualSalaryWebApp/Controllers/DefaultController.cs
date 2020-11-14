using AnnualSalary.Data;
using AnnualSalary.Models.DTO;
using AnnualSalary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AnnualSalaryWebApp.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        public Task<List<EmployeeDto>> Get()
        {
            var dataConnection = new HandlerDataConnection(); 
            return dataConnection.getAllEmployeesDto();
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
