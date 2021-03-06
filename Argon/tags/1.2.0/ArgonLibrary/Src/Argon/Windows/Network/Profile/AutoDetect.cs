﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Network;
using Argon.Windows.Network.Wifi;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
namespace Argon.Windows.Network.Profile
{
    /// <summary>
    /// 
    /// </summary>
    internal static class AutoDetect
    {
        internal const int WAIT_AFTER_SETUP = 1000;
        internal const int WAIT_BEFORE_PING = 1000;

        /// <summary>
        /// Autodetects the network profile. For the moment it works only for wifi connections!
        /// If no connections found, it return null.
        /// Use
        ///     WindowsNetworkCardManager.EnabledWindowsNetworkCardList
        ///     WifiProfileManager.ActiveWifiProfile;
        /// </summary>
        /// 
        /// <param name="profiles">profiles.</param>
        /// <returns></returns>
        public static NetworkProfile AutodetectNetworkProfile(List<NetworkProfile> profiles)
        {
            NetworkProfileHelper.FireNotifyEvent("Start autodetect");
            if (profiles == null || profiles.Count == 0)
            {
                NetworkProfileHelper.FireNotifyEvent("There's no profiles");
                NetworkProfileHelper.FireNotifyEvent("End autodetect");
                return null;
            }
            // initial setup for cards
            SetupNetworkCardForAutodetect(profiles);

            NetworkProfile selectedProfile = null;

            // one or more card (not only wifi)
            // wifi connected, 
            WifiProfile currentWifiProfile = WifiProfileManager.ActiveWifiProfile;

            // enable card
            List<WindowsNetworkCard> enabledCardList = WindowsNetworkCardManager.EnabledWindowsNetworkCardList;

            if (enabledCardList.Count == 1 && enabledCardList[0].CardType == WindowsNetworkCardType.WIRELESS && currentWifiProfile.SSID != null)
            {
                WindowsNetworkCard card = enabledCardList[0];
                // only a wifi connection avaible
                foreach (NetworkProfile item in profiles)
                {
                    // select if card is right and (ssid is right or for that profile there's no ssid)
                    if (item.NetworkCardInfo.Id.Equals(card.Id) && (currentWifiProfile.SSID.Equals(item.AssociatedWifiSSID) || string.IsNullOrWhiteSpace(item.AssociatedWifiSSID)))
                    {
                        // ok, we found it!!!
                        selectedProfile = item;

                        if (!string.IsNullOrWhiteSpace(item.AssociatedWifiSSID))
                        {
                            NetworkProfileHelper.FireNotifyEvent("The card " + card.Name + " are connected with right SSID (" + currentWifiProfile.SSID + ")");
                        }
                        NetworkProfileHelper.FireNotifyEvent("Selected profile " + item.Name + " without do anything else!!");
                        break;
                    }
                }
            }
            else
            {
                // order list by maxSpeed
                enabledCardList.Sort(CompareCardBySpeed);

                // if there's no enabled card, it's a problem!
                if (enabledCardList.Count == 0) { NetworkProfileHelper.FireNotifyEvent("No card enabled, found"); return null; }

                List<NetworkProfile> enabledProfileList = FindValidNetworkProfiles(profiles, enabledCardList, currentWifiProfile);

                // assert: enabledProfile contains the right profiles. Now we have to test it. 
                // the first with ping ok it's ok!
                bool pingOk;
                foreach (NetworkProfile item in enabledProfileList)
                {
                    NetworkProfileHelper.FireNotifyEvent("Start analizing profile " + item.Name + " with card " + item.NetworkCardInfo.Name);
                    //WindowsNetworkCardHelper.SetDeviceStatus(item.NetworkCardInfo, false);
                    NetworkProfileHelper.RunDisableNetworkCardsSetup(item);
                    NetworkProfileHelper.RunNetworkCardSetup(item);

                    // wait for a while
                    //NetworkProfileHelper.FireNotifyEvent("Wait " + (WAIT_BEFORE_PING) + " ms.");
                    //System.Threading.Thread.Sleep(WAIT_BEFORE_PING);
                    WaitUntilNetworkCardIsUp();

                    NetworkProfileHelper.FireNotifyEvent("Wait " + (WAIT_BEFORE_PING) + " ms.");
                    System.Threading.Thread.Sleep(WAIT_BEFORE_PING);

                    WindowsNetworkCard card = WindowsNetworkCardManager.RefreshStatus(item.NetworkCardInfo.Id);

                    if (card.CardType == WindowsNetworkCardType.WIRELESS)
                    {

                        // get current wifi profile only for wifi card                    
                        currentWifiProfile = WifiProfileManager.GetActiveWifiProfileForCard(card);

                        if (currentWifiProfile != null && currentWifiProfile.SSID.Equals(item.AssociatedWifiSSID) && card.NetConnectionStatus == 2)
                        {
                            // ok, we found it!!!
                            selectedProfile = item;
                            NetworkProfileHelper.FireNotifyEvent("The card " + card.Name + " are connected with right SSID (" + currentWifiProfile.SSID + ")");
                            NetworkProfileHelper.FireNotifyEvent("Selected profile " + item.Name + " without do anything else!!");
                            break;
                        }
                    }
                    else
                    {
                        pingOk = false;

                        NetworkProfileHelper.FireNotifyEvent("The card " + card.Name + " are in status " + card.NetConnectionStatus);
                        // test both static config or dynamic config
                        pingOk = PingHelper.RunPing(card.GatewayAddress);
                        pingOk = pingOk || PingHelper.RunPing(card.CurrentGatewayAddress);

                        NetworkProfileHelper.FireNotifyEvent("For card " + card.Name + " and profile " + item.Name + ", ping to gateway are " + pingOk);

                        if (pingOk)
                        {
                            selectedProfile = item;
                            NetworkProfileHelper.FireNotifyEvent("Selected profile " + item.Name + "!!");
                            break;
                        }
                    }

                    NetworkProfileHelper.FireNotifyEvent("Stop analizing profile " + item.Name + ", go to next profile");
                }

                // restore initial enabled card
                if (selectedProfile == null)
                {
                    NetworkProfileHelper.FireNotifyEvent("No profile found, so restore status card");
                    foreach (WindowsNetworkCard item in enabledCardList)
                    {
                        NetworkProfileHelper.FireNotifyEvent("Enable card " + item.Name);
                        WindowsNetworkCardHelper.SetDeviceStatus(item, true);
                    }
                }
            }

            NetworkProfileHelper.FireNotifyEvent("End autodetect");
            return selectedProfile;
        }


        /// <summary>
        /// Setups the network card for autodetect. Gets the nic associated to profiles and
        /// try to enable it. Then, disable every nic that not have a profile associated.
        /// Use WindowsNetworkCardManager.WindowsNetworkCardList
        /// </summary>
        /// <param name="profiles">The profiles.</param>
        internal static void SetupNetworkCardForAutodetect(List<NetworkProfile> profiles)
        {
            // Get every card and try to enable it
            List<WindowsNetworkCard> allCardList = WindowsNetworkCardManager.WindowsNetworkCardList;
            HashSet<WindowsNetworkCard> validCardSet = new HashSet<WindowsNetworkCard>();

            // take only the card with a profile associated
            foreach (WindowsNetworkCard item in allCardList)
            {
                foreach (NetworkProfile itemProfile in profiles)
                {
                    if (item.Id.Equals(itemProfile.NetworkCardInfo.Id) && !validCardSet.Contains(item))
                    {
                        validCardSet.Add(item);
                        Debug.WriteLine("Add card " + item.Name + " to enabled card set");
                        break;
                    }
                }
            }

            Debug.WriteLine("Found " + validCardSet.Count + " valid card!");
            Debug.WriteLine("Now disable every card not in valid set and enable all the card in valid set are disabled");

            // if a nic is used in a profile, we enable it,
            // otherwise disable it
            foreach (WindowsNetworkCard item in allCardList)
            {
                if (item.Enabled && !validCardSet.Contains(item))
                {
                    Debug.WriteLine("Disable card " + item.Name, ", it's not in valid set");
                    WindowsNetworkCardHelper.SetDeviceStatus(item, false);
                }
                else if (!item.Enabled && validCardSet.Contains(item))
                {
                    Debug.WriteLine("Enable card " + item.Name + " it's in valid set but disabled");
                    WindowsNetworkCardHelper.SetDeviceStatus(item, true);
                }
            }
            // wait for a while
            Debug.WriteLine("Wait " + WAIT_AFTER_SETUP + " ms.");
            System.Threading.Thread.Sleep(WAIT_AFTER_SETUP);
        }


        /// <summary>
        /// Finds the valid network profiles. Filter the profile with enabled card. If a profile has an SSI associated
        /// this SSID must be the current SSID
        /// </summary>
        /// <param name="profiles">The profiles.</param>
        /// <param name="enabledCardList">The enabled card list.</param>
        /// <param name="currentWifiProfile">The current wifi profile.</param>
        /// <returns></returns>
        internal static List<NetworkProfile> FindValidNetworkProfiles(List<NetworkProfile> profiles, List<WindowsNetworkCard> enabledCardList, WifiProfile currentWifiProfile)
        {
            List<NetworkProfile> enabledProfileList = new List<NetworkProfile>();
            foreach (WindowsNetworkCard itemCard in enabledCardList)
            {
                foreach (NetworkProfile itemProfile in profiles)
                {
                    // check if card is right
                    if (itemCard.Id.Equals(itemProfile.NetworkCardInfo.Id))
                    {
                        // check if is a wifi connection
                        if (currentWifiProfile != null)
                        {
                            // check if card has an associated ssid
                            if (itemProfile.AssociatedWifiSSID != null && itemProfile.AssociatedWifiSSID.Trim().Length > 0)
                            {
                                // check if profile ssid and current ssid are equal
                                if (currentWifiProfile.SSID.Equals(itemProfile.AssociatedWifiSSID))
                                {
                                    enabledProfileList.Add(itemProfile);
                                }
                                else
                                {
                                    // wrogin SSID, ignore it
                                }
                            }
                            else
                            {
                                // no SSID associated, every SSID is ok
                                enabledProfileList.Add(itemProfile);
                            }
                        }
                        else
                        {
                            // there's no current wifi network connected
                            // card is enabled, profile is associated this profile
                            enabledProfileList.Add(itemProfile);
                        }
                    }
                }
            }
            return enabledProfileList;
        }

        /// <summary>
        /// Compares the card by speed.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        private static int CompareCardBySpeed(WindowsNetworkCard x, WindowsNetworkCard y)
        {
            return x.MaxSpeed.CompareTo(y.MaxSpeed);
        }

        #region WaitUntilNetworkCardIsUp

        /// <summary>
        /// Waits the until network card is up.
        /// </summary>
        /// <returns></returns>
        private static bool WaitUntilNetworkCardIsUp()
        {
            NetworkCardUp = false;
            finished = false;

            try
            {
                NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);

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
                // remove every time
                NetworkChange.NetworkAvailabilityChanged -= NetworkChange_NetworkAvailabilityChanged;
            }

            return NetworkCardUp;
        }

        /// <summary>
        /// Handles the NetworkAvailabilityChanged event of the NetworkChange control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Net.NetworkInformation.NetworkAvailabilityEventArgs"/> instance containing the event data.</param>
        private static void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
            {
                finished = true;
                NetworkCardUp = true;
                Console.WriteLine("Network is Available");
            }
            else
            {
                NetworkCardUp = false;
                Console.WriteLine("Network is Unavailable");
            }
        }

        /// <summary>
        /// max wait 15 seconds
        /// </summary>
        public static int MAX_WAIT = 15000;
       
        /// <summary>
        /// idle time 10 ms
        /// </summary>
        public static int IDLE_TIME = 10;

        /// <summary>
        /// 
        /// </summary>
        public static bool finished;
        /// <summary>
        /// 
        /// </summary>
        public static bool NetworkCardUp;

        private static long ClimbSmallHill()
        {
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < MAX_WAIT / IDLE_TIME; i++)
            {
                Thread.Sleep(IDLE_TIME);

                if (finished)
                {
                    sw.Stop();
                    Console.WriteLine("Termino");
                    return sw.ElapsedMilliseconds;
                }

            }

            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        internal delegate long StatisticalData();

        #endregion

    }
}
