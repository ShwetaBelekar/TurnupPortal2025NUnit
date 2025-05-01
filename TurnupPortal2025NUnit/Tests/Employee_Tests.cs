using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnupPortal2025NUnit.Pages;
using TurnupPortal2025NUnit.Utilities;

namespace TurnupPortal2025NUnit.Tests
{
    [TestFixture]
    public class Employee_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {
            driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //User has logged in successfully
            loginPageObj.VerifyUserInHomePage(driver);

            EmployeeHomePage employeeHomePageObj = new EmployeeHomePage();
            employeeHomePageObj.NavigateToEmployeesPage(driver);

        }

        [Test]
        public void CreateEmployee_Test()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployeeRecord(driver);

        }

        [Test]
        public void EditEmployee_Test()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployeeRecord(driver);

        }

        [Test]
        public void DeleteEmployee_Test()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployeeRecord(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }



    }
}
