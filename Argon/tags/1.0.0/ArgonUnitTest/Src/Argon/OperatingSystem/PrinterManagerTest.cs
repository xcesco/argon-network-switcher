using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
//using NUnit.Framework;
//using NUnit.Framework.SyntaxHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Argon.OperatingSystem
{
    [TestClass]
    public class PrinterManagerTest
    { 
        [TestMethod]
        public void Test01()
        {
            foreach (String item in PrinterSettings.InstalledPrinters)
            {
                Console.WriteLine(item);
            }

            bool esito = PrinterManager.SetDefaultPrinter(@"\\dc04insiel\TS-PAD-PT-1");
            Assert.IsTrue(esito);
        }
    }
}
