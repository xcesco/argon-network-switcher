using Argon.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Argon.Windows
{    
    /// <summary>
    ///This is a test class for WindowsExecutableManagerTest and is intended
    ///to contain all WindowsExecutableManagerTest Unit Tests
    ///</summary>
    [TestClass]
    public class WindowsExecutableManagerTest
    {     
        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for RunningProcesses
        ///</summary>
        [TestMethod()]
        public void RunningProcessesTest()
        {
            List<RunningWindowsExecutable> actual;
            actual = WindowsExecutableManager.RunningProcesses;

            foreach(RunningWindowsExecutable item in actual)
            {

                if ("firefox.exe".Equals(item.Name))
                {
                    item.Kill=true;
                    Console.WriteLine(item.Name);
                    WindowsExecutor.Execute(item);
                }
            }
        }
    }
}
