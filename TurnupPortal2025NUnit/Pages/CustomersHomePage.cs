using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TurnupPortal2025NUnit.Utilities;

namespace TurnupPortal2025NUnit.Pages
{
    public class CustomersHomePage
    {
        public void NavigateToCustomersPage(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Alert not present within the specified time.");
            }
            //Navigate to customers Page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a", 10);

            IWebElement customersOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            customersOption.Click();
            Thread.Sleep(2000);

        }




    }
}
