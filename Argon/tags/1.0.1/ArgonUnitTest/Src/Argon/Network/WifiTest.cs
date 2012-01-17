using System;
using System.Collections.Generic;
using System.Management;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArgonUnitTest.Src.Argon.Network
{

    [TestClass]
    public class WifiTest
    {
        private static string wql_listar_adaptadores_conectados = "SELECT * FROM MSNdis_80211_BaseServiceSetIdentifier WHERE Active = True";
        private static string wql_listar_redes = "SELECT * FROM MSNDis_80211_BSSIList";

        private static void WIFI_list()
        {
            /* Establecer una conexiÃ³n con el entorno de administraciÃ³n */
            ManagementScope managementScope = new
            ManagementScope("\\\\.\\root\\wmi");

            System.Management.ObjectQuery objectQuery = new System.Management.ObjectQuery(wql_listar_adaptadores_conectados);
            ManagementObjectSearcher managementObjectSearcher = new
            ManagementObjectSearcher(managementScope, objectQuery);
            ManagementObjectCollection moc = managementObjectSearcher.Get();
            ManagementObjectCollection.ManagementObjectEnumerator moe = moc.GetEnumerator();
            moe.MoveNext();
            ManagementBaseObject[] objarr =
            (ManagementBaseObject[])moe.Current.Properties["Ndis80211BSSIList"].Value;

            if (objarr != null)
            {
                foreach (ManagementBaseObject obj in objarr)
                {
                    char[] ssid =
                    Encoding.ASCII.GetChars((byte[])obj["Ndis80211Ssid"]);
                    Console.Write("SSID: ");
                    int i;
                    for (i = 0; i < 32 && ssid[i] != '\0'; i++)
                    {
                        Console.Write(ssid[i]);
                    }
                    uint rs = (uint)obj["Ndis80211Rssi"];
                    Console.Write(".");
                    Console.WriteLine(" RSSI: " + rs);
                }
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM MSNdis_80211_ServiceSetIdentifier WHERE Active='True'");
                

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("MSNdis_80211_ServiceSetIdentifier instance");
                    Console.WriteLine("-----------------------------------");

                   /* if (queryObj["Ndis80211SsId"] == null)
                        Console.WriteLine("Ndis80211SsId: {0}", queryObj["Ndis80211SsId"]);
                    else
                    {
                        Byte[] arrNdis80211SsId = (Byte[])(queryObj["Ndis80211SsId"]);
                        foreach (Byte arrValue in arrNdis80211SsId)
                        {
                            Console.WriteLine("Ndis80211SsId: {0}", arrValue);
                        }
                    }*/
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("An error occurred while querying for WMI data: " + e.Message);
            }
        }
    }
}
