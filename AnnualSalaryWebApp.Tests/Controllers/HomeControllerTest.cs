using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnnualSalaryWebApp;
using AnnualSalaryWebApp.Controllers;
using System.Net.Http;
using System.Web.Http.Hosting;
using System.Web.Http;
using System.Net;

namespace AnnualSalaryWebApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EmployeeList()
        {
            // Arrange
            //var controller = new EmployeeController();

            //controller.Request = new HttpRequestMessage();
            //controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            //// Act
            ////    ViewResult result = controller.Contact() as ViewResult;

            //var response = controller.Get();

            //// Assert
            //Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
