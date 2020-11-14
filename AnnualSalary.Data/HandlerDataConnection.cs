using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalary.Data
{
    public class HandlerDataConnection
    {

        private string _apiUrl;
        static HttpClient client = new HttpClient();

        public HandlerDataConnection()
        {
            this._apiUrl = ConfigurationManager.AppSettings["Url_API_Repository"].ToString();
        }



    }
}
