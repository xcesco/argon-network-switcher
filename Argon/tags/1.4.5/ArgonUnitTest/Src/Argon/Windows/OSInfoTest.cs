using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.Windows;

namespace Argon.OperatingSystem
{
    [TestClass]
    public class OSInfoTest
    {
        [TestMethod]
        public void TestInfo()
        {
            Console.WriteLine(OSInfo.Name);
            Console.WriteLine(OSInfo.OperatingSystem);
        }
    }
}
