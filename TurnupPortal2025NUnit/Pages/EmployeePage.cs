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
    public class EmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            try
            {
                IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Create button hasn't been found.");
            }
            
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Nisha");

            IWebElement uusernameTextbox = driver.FindElement(By.Id("Username"));
            uusernameTextbox.SendKeys("Nisha123");

            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.SendKeys("Home001");
            Thread.Sleep(3000);

            IWebElement paasswordTextbox = driver.FindElement(By.Id("Password"));
            paasswordTextbox.SendKeys("Moon001!");

            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("Moon001!");

            IWebElement isAdminTickbox = driver.FindElement(By.Id("IsAdmin"));
            isAdminTickbox.Click();
            Thread.Sleep(2000);

            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("Car");

            IWebElement groupsTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupsTextbox.Click();
            Thread.Sleep(3000);

            IWebElement icOption = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[73]"));
            icOption.Click();

            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(7000);

            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToListButton.Click();
            Thread.Sleep(3000);
            
            driver.Navigate().Refresh();

            IWebElement goToTheLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToTheLastPageButton.Click();
            Thread.Sleep(3000);

            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newName.Text == "Nisha")
            {
                Assert.Pass("New Name record created Successfully!");
            }
            else
            {
                Assert.Fail("New name record has not been created!");
            }

        }
        public void EditEmployeeRecord(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[3]/td[3]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            IWebElement naameTextbox = driver.FindElement(By.Id("Name"));
            naameTextbox.Clear();
            naameTextbox.SendKeys("Asha");
            Thread.Sleep(2000);

            IWebElement saaveButton = driver.FindElement(By.Id("SaveButton"));
            saaveButton.Click();

            IWebElement baackToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            baackToListButton.Click();
            Thread.Sleep(3000);

            IWebElement laastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            laastPageButton.Click();

            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[3]/td[1]"));
            
            Assert.That(name.Text == "Asha", "Asha is not Present!");
            //if (name.Text == "Asha")
            //{
            //    Console.WriteLine("Asha is Present!");
            //}
            //else
            //{
            //    Console.WriteLine("Asha is not Present!");
            //}

        }
        public void DeleteEmployeeRecord(IWebDriver driver)
        {
            IWebElement llaastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            llaastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[2]/td[3]/a[2]"));
            deleteButton.Click(); 
            driver.SwitchTo().Alert().Accept();

            IWebElement llaasstPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            llaasstPageButton.Click();

            IWebElement naame = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[2]/td[1]"));

            if (naame.Text == "Asha")
            {
                Console.WriteLine("Asha is not present!");
            }
            else
            {
                Console.WriteLine("Asha is present!");
            }
        }
    }
}
