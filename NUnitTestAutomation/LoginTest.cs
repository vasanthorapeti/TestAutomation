using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestAutomation
{
    [TestFixture]
    class LoginTest
    {
        [Test]
        public void LoginCMS1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\BIECode\ChromeDriver1");
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            IWebElement searchInput = driver.FindElement(By.Name("search"));
            searchInput.SendKeys("Karnataka");
            searchInput.SendKeys(Keys.Enter);
            string str = driver.FindElement(By.Id("firstHeading")).Text;
            //string str = "abc";
            Assert.AreEqual("Karnataka", str);
            System.Threading.Thread.Sleep(4000);
            driver.Quit();
        }        
    }
}
