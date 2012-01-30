using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.Network;
using Argon.OperatingSystem.Network;
//using NUnit.Framework;

namespace Argon.OperatingSystem
{
    [TestClass]
    public class ProxyConfiguratorTest
    {
        [TestMethod]
        public void testWriteProxy()
        {
            ProxyConfiguration config = new ProxyConfiguration();

            config.Enabled = true;
            config.Port = 80;
            config.ServerAddress="pippo";
            config.ProxyOverrideEnabled = true;
            config.ProxyOverride = "192.168.*";

            ProxyConfigurationManager.Apply(config);

            Console.WriteLine("Esecuzione terminata");
        }

        [TestMethod]
        public void testReadProxy()
        {            
            ProxyConfiguration config=ProxyConfigurationManager.ReadConfig();

            Console.WriteLine("Enabled: "+config.Enabled);
            Console.WriteLine("Address: " + config.ServerAddress);
            Console.WriteLine("Port: " + config.Port);
            Console.WriteLine("Override Enabled: " + config.ProxyOverrideEnabled);
            Console.WriteLine("Override: " + config.ProxyOverride);

            Console.WriteLine("Esecuzione terminata");
        }
    }
}
