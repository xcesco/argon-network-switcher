using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.Windows;

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

            bool esito = PrinterManager.SetDefaultPrinter(@"\\host\printer");
            Assert.IsTrue(esito);
        }
    }
}
