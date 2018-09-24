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
            string[] lines = { "Bengaluru", "Karnatata", "India" };
            string result;
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
            result = "test";
            Assert.AreEqual("test", result);
        }

        [Test]
        public void LoginOnline()
        {
            string[] lines = { "Bengaluru", "Karnatata", "India" };
            string result;
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
            result = "test";
            Assert.AreEqual("test", result);
        }
    }
}
