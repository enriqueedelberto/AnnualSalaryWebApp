using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;
using AnnualSalaryWebApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AnnualSalaryWebApp.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        private const int COUNT_EMPLOYEES = 2;
        private const string HOURLY_SALARY_EMPLOYEE = "HourlySalaryEmployee";
        private const string MONTHLY_SALARY_EMPLOYEE = "MonthlySalaryEmployee";


        [TestMethod]
        public  void GetAllEmployees()
        {
            var controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var response =  controller.Get().Result;
            
            Assert.AreEqual(COUNT_EMPLOYEES, response.Count);
        }


        [TestMethod]
        public  void GetEmployee()
        {
            var controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var id = "1";
            var response =  controller.Get(id).Result;

            Assert.AreEqual( 1, response.Count);
        }


        [TestMethod]
        public  void GetHourlySalaryEmployee()
        {
            var controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var id = "1";
            var response =  controller.Get(id).Result;
            var employee = response[0];
            var annualSalaryCalculated = 120 * employee.hourlySalary * 12;

            Assert.AreEqual(annualSalaryCalculated, employee.annualSalary);
        }

        [TestMethod]
        public void GetMonthlySalaryEmployee()
        {
            var controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var id = "2";
            var response =   controller.Get(id).Result;
            var employee = response[0];
            var annualSalaryCalculated =   employee.monthlySalary * 12;

            Assert.AreEqual(annualSalaryCalculated, employee.annualSalary);
        }



    }
}
