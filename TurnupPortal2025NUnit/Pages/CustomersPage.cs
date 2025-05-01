using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupPortal2025NUnit.Pages
{
    public class CustomersPage
    {
        public void CreateCustomersRecord(IWebDriver driver)
        {
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            IWebElement nameeTextbox = driver.FindElement(By.Id("Name"));
            nameeTextbox.SendKeys("Rani");


            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            //string mainWindowHandle = driver.CurrentWindowHandle;
            editContactButton.Click();
            driver.SwitchTo().Frame(0);

            //List<string> windowHandles = driver.WindowHandles.ToList();

            //string newWindowHandle = windowHandles.Last();

            //driver.SwitchTo().Window(newWindowHandle);

            //Thread.Sleep(5000);

            IWebElement firstNameTextbox = driver.FindElement(By.Id("FirstName"));
            firstNameTextbox.SendKeys("Road");

            IWebElement lastNameTextbox = driver.FindElement(By.Id("LastName"));
            lastNameTextbox.SendKeys("Way");

            IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            phoneTextbox.SendKeys("123");
            Thread.Sleep(2000);
            IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            saveContactButton.Click();

            driver.SwitchTo().ParentFrame();
            Thread.Sleep(2000);
            //driver.SwitchTo().Window(mainWindowHandle);

            IWebElement sameAsAboveTickbox = driver.FindElement(By.Id("IsSameContact"));
            sameAsAboveTickbox.Click();

            IWebElement gstTextbox = driver.FindElement(By.Id("GST"));
            gstTextbox.SendKeys("10");

            IWebElement ssaveButton = driver.FindElement(By.XPath("//input[@value='Save']"));
            ssaveButton.Click();
            Thread.Sleep(3000);
            IWebElement aadminiistrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            aadminiistrationtab.Click();

            IWebElement cuustomersOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            cuustomersOption.Click();
            Thread.Sleep(2000);

            IWebElement llaassttPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
            llaassttPageButton.Click();
            Thread.Sleep(2000);

            IWebElement neewName = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[2]"));

            if (neewName.Text == "Rani")
            {
                Assert.Pass("New entry is created!");
            }
            else
            {
                Assert.Fail("New entry is not been created!");
            }

        }
        public void EditCustomersRecord(IWebDriver driver)
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement eeditButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[7]/td[4]/a[1]"));
            eeditButton.Click();
            driver.SwitchTo().Frame(0);


            IWebElement naameeTextbox = driver.FindElement(By.Id("Name"));
            naameeTextbox.Clear();
            naameeTextbox.SendKeys("XYZ");

            IWebElement saveeButton = driver.FindElement(By.Id("submitButton"));
            saveeButton.Click();
            driver.SwitchTo().ParentFrame();
            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            IWebElement llastPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
            llastPageButton.Click();
            Thread.Sleep(5000);

            IWebElement naamme = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[7]/td[2]"));

            if (naamme.Text == "XYZ")
            {
                Console.WriteLine("XYZ is Present");
            }
            else
            {
                Console.WriteLine("XYZ is not Present");
            }
        }
        public void DeleteCustomersRecord(IWebDriver driver)
        {
            IWebElement lasstPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
            lasstPageButton.Click();

            IWebElement deeleteButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[5]/td[4]/a[2]"));
            deeleteButton.Click();
            driver.SwitchTo().Alert().Accept();

            IWebElement laasstPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
            laasstPageButton.Click();

            IWebElement id = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[5]/td[1]"));

            if (id.Text == "3455")
            {
                Console.WriteLine("3455 is not present");
            }
            else
            {
                Console.WriteLine("3455 is present");
            }

        }
    }
}
