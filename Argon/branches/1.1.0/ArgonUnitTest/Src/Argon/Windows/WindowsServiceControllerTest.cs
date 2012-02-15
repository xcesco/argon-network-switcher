using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using Argon.OperatingSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.Windows;

namespace Argon.OperatingSystem
{
    [TestClass]
    public class WindowsServiceControllerTest
    {
        [TestMethod]
        public void test01()
        {
            List<WindowsService> lista = WindowsServiceManager.GetWindowsServicesList();

            foreach (WindowsService item in lista)
            {
                Console.WriteLine(item.Name+" "+item.DisplayName+" "+item.Status);
            }
        }

        [TestMethod]
        public void test02()
        {
            Assert.AreEqual(true, true);
        }
    }
}
