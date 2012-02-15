using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace Argon.Windows.Network
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class PingHelper
    {
        /// <summary>
        /// Runs the ping.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <returns></returns>
        public static bool RunPing(string ip)
        {
            bool ret = false;

            if (ip == null || ip.Trim().Length == 0) return false;
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(ip, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                ret = true;                
            }

            return ret;
        }
    }
}
