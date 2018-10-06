using System;
using NUnit.Framework;

namespace NUnitTestAutomation
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void LoginCMS()
        {
            string newlocation = TestContext.Parameters.Get("location");
          //  string newlocation = System.Environment.GetEnvironmentVariable("OneDrive");
            string[] lines = { "Bengaluru", "Karnatata", "India", newlocation };
            string result;
      
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
          
            result = "test";
            Console.WriteLine("This what I want to display " + newlocation);
            Assert.AreEqual("test", result);
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
