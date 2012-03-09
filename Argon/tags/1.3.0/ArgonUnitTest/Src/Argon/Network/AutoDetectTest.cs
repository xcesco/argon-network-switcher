using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.OperatingSystem;
using System.IO;
using System.Net.NetworkInformation;
using Argon.Windows.Network.Profile;

namespace Argon.Windows.Network
{
    [TestClass]
    public class AutoDetectTest
    {

        /// <summary>
        /// Setups the profiles.
        /// </summary>
        /// <returns></returns>
        public List<NetworkProfile> SetupProfiles()
        {
            List<NetworkProfile> list = new List<NetworkProfile>();

            string file = Path.GetFullPath(@"..\..\..\ArgonUnitTest\TestProfiles.xml");

            Console.WriteLine(file);
            Assert.IsTrue(File.Exists(file));

            list = NetworkProfileHelper.Load(file,"");

            return list;
        }

        [TestMethod]
        public void TestPing()
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send("172.22.8.2", timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address: {0}", reply.Address.ToString());
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            }
        }

        /// <summary>
        /// Tests the auto detect.
        /// </summary>
        [TestMethod]
        public void TestAutoDetect()
        {
            Console.WriteLine("Start");

            // load test profiles
            List<NetworkProfile> networkProfileList = SetupProfiles();

            NetworkProfile current=NetworkProfileHelper.AutoDetectNetworkProfile(networkProfileList);


            if (current != null) { Console.WriteLine("Profile name: {0}, Wifi SSID: {1} ", current.Name, current.AssociatedWifiSSID); }
            else
            {
                Console.WriteLine("No profile found");
            }

            Console.WriteLine("Finished!");
        }

        [TestMethod]
        public void ShowNetworkInterfaces()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("Interface information for {0}.{1}     ",
                    computerProperties.HostName, computerProperties.DomainName);
            if (nics == null || nics.Length < 1)
            {
                Console.WriteLine("  No network interfaces found.");
                return;
            }

            Console.WriteLine("  Number of interfaces .................... : {0}", nics.Length);
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                Console.WriteLine();
                Console.WriteLine(adapter.Description);
                Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                Console.WriteLine("  Physical Address ........................ : {0}",
                           adapter.GetPhysicalAddress().ToString());
                Console.WriteLine("  Operational status ...................... : {0}",
                    adapter.OperationalStatus);
                string versions = "";

                // Create a display string for the supported IP versions.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }
                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }
                Console.WriteLine("  IP version .............................. : {0}", versions);
                //ShowIPAddresses(properties);

                // The following information is not useful for loopback adapters.
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    continue;
                }
                Console.WriteLine("  DNS suffix .............................. : {0}",
                    properties.DnsSuffix);
                
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();
                    Console.WriteLine("  MTU...................................... : {0}", ipv4.Mtu);
                    if (ipv4.UsesWins)
                    {

                        IPAddressCollection winsServers = properties.WinsServersAddresses;
                        if (winsServers.Count > 0)
                        {
                           // string label;
                            //label = "  WINS Servers ............................ :";
                            // ShowIPAddresses(label, winsServers);
                        }
                    }
                }

                Console.WriteLine("  DNS enabled ............................. : {0}",
                    properties.IsDnsEnabled);
                Console.WriteLine("  Dynamically configured DNS .............. : {0}",
                    properties.IsDynamicDnsEnabled);
                Console.WriteLine("  Receive Only ............................ : {0}",
                    adapter.IsReceiveOnly);
                Console.WriteLine("  Multicast ............................... : {0}",
                    adapter.SupportsMulticast);
                // ShowInterfaceStatistics(adapter);

                Console.WriteLine();
            }
        }
    }
}
