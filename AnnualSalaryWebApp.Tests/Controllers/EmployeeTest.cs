using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;
using AnnualSalaryWebApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnnualSalaryWebApp.Tests.Controllers
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var response = controller.Get();
            
            Assert.AreEqual(HttpStatusCode.OK, response.Status);
        }
    }
}
