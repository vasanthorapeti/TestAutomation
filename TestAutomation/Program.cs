using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Zero line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\BIECode\TestAutomation\WriteLines.txt", lines);
        }
    }
}
