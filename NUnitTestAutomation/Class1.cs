using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string[] lines = { "Bengaluru", "Karnatata", "India", newlocation };
            string result;
      
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
          
            result = "test";
            Console.WriteLine(TestContext.Parameters["location"]);
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
