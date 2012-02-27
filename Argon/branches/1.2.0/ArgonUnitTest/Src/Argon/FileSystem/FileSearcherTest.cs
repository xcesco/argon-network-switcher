using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Argon.FileSystem
{
    [TestClass]
    public class FileSearcherTest
    {

        private static int counter;
        private static int errorCounter;

        public static int ErrorCounter
        {
            get { return FileSearcherTest.errorCounter; }
            set { FileSearcherTest.errorCounter = value; }
        }

        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
        
        
        /// <summary>
        /// Test01s this instance.
        /// </summary>
        [TestMethod]
        public void test01()
        {
            Counter = 0;
            FileFinder finder = new FileFinder();

            finder.OnFileFound += new FoundFileHandler(OnDisplay);
            finder.OnError += new ErrorHandler(OnError);

            finder.Execute(@"D:\My Virtual Machine", @"*.iso", false, false, -1);
            Assert.IsTrue(Counter > 0);
            Assert.IsFalse(ErrorCounter > 0);
        }


        public static void OnDisplay(FileFinder sender, string file)
        {
            Counter++;

            Debug.WriteLine("Found " + file);
        }

        public static void OnError(Exception ex)
        {
            ErrorCounter++;
            Debug.WriteLine("Exception " + ex);
        }

    }
}
