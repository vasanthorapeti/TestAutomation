using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestAutomation
{
    [TestFixture]
    class LoginTest
    {
        [Test]
        public void LoginCMS1()
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
