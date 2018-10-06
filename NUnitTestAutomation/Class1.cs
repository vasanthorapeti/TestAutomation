using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestAutomation
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void LoginCMS()
        {
            /*
            string newlocation = TestContext.Parameters.Get("location");
            string str = "another value";
          //  string newlocation = System.Environment.GetEnvironmentVariable("OneDrive");
            string[] lines = { "Bengaluru", "Karnatata", "India", newlocation, str };
            string result;
      
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
          
            result = "test";
            Console.WriteLine("This what I want to display " + newlocation);
            Assert.AreEqual("test", result);
            */
            IWebDriver driver = new ChromeDriver(@"C:\BIECode\ChromeDriver1");
            driver.Navigate().GoToUrl(TestContext.Parameters.Get("URL"));
            IWebElement searchInput = driver.FindElement(By.Name("search"));
            searchInput.SendKeys(TestContext.Parameters.Get("SearchWord"));
            searchInput.SendKeys(Keys.Enter);
            string str = driver.FindElement(By.Id("firstHeading")).Text;
            //string str = "abc";
            Assert.AreEqual("Karnataka", str);
            System.Threading.Thread.Sleep(4000);
            driver.Quit();
        }

        [Test]
        [Category("Online")]
        public void LoginOnline()
        {
            string[] lines = { "Bengaluru", "Karnatata", "India" };
            string result;
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
            result = "test";
            Console.WriteLine(TestContext.Parameters["testParameter1"]);
            Assert.AreEqual("test", result);
        }
    }
}
