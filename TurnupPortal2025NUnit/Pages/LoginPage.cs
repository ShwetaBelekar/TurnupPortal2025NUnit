using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TurnupPortal2025NUnit.Utilities;

namespace TurnupPortal2025NUnit.Pages
{
    public class LoginPage
    {
        // Functions that allow users to TurnUp Portal
        public void LoginActions(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            try
            {
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
            }
            catch(Exception ex)
            {
                Assert.Fail("Username textbox not located.");
            }

            Wait.WaitToBeVisible(driver, "Id", "Password", 7);

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);
        }

        public void VerifyUserInHomePage(IWebDriver driver)
        {
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged in successfully. Test Passed!");
            }
            else
            {
                Console.WriteLine("User has not logged in. Test Failed!");
            }

        }

    }       

        
    
}
