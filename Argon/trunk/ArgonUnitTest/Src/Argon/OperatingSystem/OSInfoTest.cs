using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Argon.OperatingSystem
{
    [TestClass]
    public class OSInfoTest
    {
        [TestMethod]
        public void TestInfo()
        {
            Console.WriteLine(OSInfo.Name);
        }
    }
}
