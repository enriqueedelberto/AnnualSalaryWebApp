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
        

        public HandlerDataConnection()
        {
          
            this._apiUrl = ConfigurationManager.AppSettings["Url_API_Repository"].ToString();
            this.client.BaseAddress = new Uri(this._apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

           
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

        



    }
}
