using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.OperatingSystem;
//using NUnit.Framework;
//using NUnit.Framework.SyntaxHelpers;

namespace Argon.OperatingSystem
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
            map.Password = "3dylan3dog3";
            map.Username=@"INSIEL\908099";

            Assert.IsTrue(DriveMapManager.Mount(map));
            Assert.IsTrue(DriveMapManager.Unmount(map));
            Assert.IsTrue(DriveMapManager.Test(map));
        }
    }
}
