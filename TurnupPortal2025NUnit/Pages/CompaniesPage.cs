using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupPortal2025NUnit.Pages
{
    public class CompaniesPage
    {
        public void CreateCompaniesRecord(IWebDriver driver)
        {
            
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(3000);

            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Sony");

            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            editContactButton.Click();
            driver.SwitchTo().Frame(0);

            IWebElement firstNameTextbox = driver.FindElement(By.Id("FirstName"));
            firstNameTextbox.SendKeys("Tony");

            IWebElement lastNameTextbox = driver.FindElement(By.Id("LastName"));
            lastNameTextbox.SendKeys("tom");

            IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            phoneTextbox.SendKeys("456");

            IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            saveContactButton.Click();

            driver.SwitchTo().ParentFrame();
            Thread.Sleep(5000);
            IWebElement createNewGroupButton = driver.FindElement(By.Id("CreateGroupButton"));
            createNewGroupButton.Click();
            Thread.Sleep(2000);
            
            driver.SwitchTo().Frame(1);

            IWebElement naameTextbox = driver.FindElement(By.XPath("//input[@data-val-required='Name is Required']"));
            naameTextbox.SendKeys("Pearl");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            driver.SwitchTo().ParentFrame();

            IWebElement saveCompanyButton = driver.FindElement(By.Id("SaveButton"));
            saveCompanyButton.Click();
            
            
            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToListButton.Click(); 
            driver.Navigate().Refresh();

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"companiesGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            

            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"companiesGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            
            if (newName.Text == "Sony")
            {
                Assert.Pass(" Sony is present");
            }
            else
            {
                Assert.Fail("Sony is not present");
            }

        }
    }
}
