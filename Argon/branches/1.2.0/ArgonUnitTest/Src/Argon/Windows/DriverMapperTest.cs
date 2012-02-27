using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.OperatingSystem;

namespace Argon.Windows
{
    [TestClass]
    public class DriverMapperTest
    {
        [TestMethod]
        public void testMountDevice()
        {
            DriveMap map = new DriveMap();

            map.Drive = "Z:";
            map.RealPath = @"127.0.0.1\c$";
            map.Password = "pwd";
            map.Username=@"TEST\TEST";

            Assert.IsTrue(DriveMapManager.Mount(map));
            Assert.IsTrue(DriveMapManager.Unmount(map));
            Assert.IsTrue(DriveMapManager.Test(map));
        }
    }
}
