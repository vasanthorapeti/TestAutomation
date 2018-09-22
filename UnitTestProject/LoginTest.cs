using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace UnitTestProject
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\BIECode\ChromeDriver1");
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");            
            IWebElement searchInput = driver.FindElement(By.Name("search"));
            searchInput.SendKeys("Karnataka");
            searchInput.SendKeys(Keys.Enter);
            string str = driver.FindElement(By.Id("firstHeading")).Text;
            Assert.AreEqual("Karnataka", str);
            System.Threading.Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
