using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Argon.Windows.Network
{
    /// <summary>
    /// 
    /// </summary>
    public class WindowsNetworkCardEventHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsNetworkCardEventHandler"/> class.
        /// </summary>
        /// <param name="card">The card.</param>
        public WindowsNetworkCardEventHandler(WindowsNetworkCard card)
        {
            nic = card;
        }

        /// <summary>
        /// 
        /// </summary>
        protected WindowsNetworkCard nic;

        /// <summary>
        /// Waits the until network card is up.
        /// </summary>
        /// <returns></returns>
        public bool WaitUntilNetworkCardIsUp(int maxWaitTimeValue = MAX_WAIT)
        {
            NetworkCardUp = false;            

            maxWaitTime = maxWaitTimeValue;
            pingCounter = 0;

            try
            {
                StatisticalData data = ClimbSmallHill;
                IAsyncResult ar = data.BeginInvoke(null, null);

                while (!ar.IsCompleted)
                {
                    Console.WriteLine("Waiting.....");
                    Thread.Sleep(20 * IDLE_TIME);

                }
                Console.WriteLine("Wait is finished...");
                Console.WriteLine("Time Taken for Network card is up ....{0}",
                data.EndInvoke(ar).ToString() + "..Seconds");
            }
            finally
            {
            }

            return NetworkCardUp;
        }

        private int maxWaitTime;

        /// <summary>
        /// max wait 15 seconds
        /// </summary>
        public const int MAX_WAIT = 15000;

        /// <summary>
        /// idle time 10 ms
        /// </summary>
        public const int IDLE_TIME = 10;

        public int pingCounter;
       
        public const int MAX_PING = 5;


        /// <summary>
        /// 
        /// </summary>
        public bool NetworkCardUp;

        /// <summary>
        /// Climbs the small hill.
        /// </summary>
        /// <returns></returns>
        private long ClimbSmallHill()
        {
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < maxWaitTime / IDLE_TIME; i++)
            {
                Thread.Sleep(IDLE_TIME);

                nic = WindowsNetworkCardManager.RefreshStatus(nic.Id);

                Debug.WriteLine("Device connected " + nic.Connected);
                Debug.WriteLine("Device gateway " + nic.GatewayAddress);
                NetworkCardUp = PingHelper.RunPing(nic.GatewayAddress);

                if (nic.Connected && nic.GatewayAddress == "" && !NetworkCardUp)
                {
                    pingCounter++;
                }

                Debug.WriteLine("Ping on " + nic.GatewayAddress + " " + NetworkCardUp);

                if (pingCounter >= MAX_PING || NetworkCardUp)
                {
                    sw.Stop();
                    Debug.WriteLine("Termino");
                    return sw.ElapsedMilliseconds;
                }

            }

            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        internal delegate long StatisticalData();

    }
}
