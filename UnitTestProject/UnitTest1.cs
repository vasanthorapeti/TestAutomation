using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //IWebDriver driver = new FirefoxDriver();
            //driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            //IWebElement search = driver.FindElement(By.Name("search"));
            //search.SendKeys("Karnataka");

            string[] lines = { "Bengaluru", "Karnatata", "India" };
            string result;
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
            result = "test";
            Assert.AreEqual("test", result);

        }
    }
}
