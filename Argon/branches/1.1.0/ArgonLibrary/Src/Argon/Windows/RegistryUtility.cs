using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;

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
namespace Argon.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegistryKeyType : int
    {
        /// <summary>
        /// 
        /// </summary>
        CurrentUser = 1,
        /// <summary>
        /// 
        /// </summary>
        LocalMachine = 2
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class RegistryUtility
    {

        /// <summary>
        /// Reads the byte array value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="path">The path.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static byte[] ReadByteArrayValue(RegistryKeyType type, string path, string name)
        {
            byte[] def=new byte[0];
            return (byte[] )ReadValue(type,path, name, def);
        }

        /// <summary>
        /// Reads the string value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="path">The path.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static string ReadStringValue(RegistryKeyType type, string path, string name)
        {
            return (string) ReadValue(type, path, name, "");
        }

        /// <summary>
        /// Reads the int value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="path">The path.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static int ReadIntValue(RegistryKeyType type, string path, string name)
        {
            return (int)ReadValue(type, path, name, 0);
        }

        /// <summary>
        /// Reads the int value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="path">The path.</param>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static int ReadIntValue(RegistryKeyType type, string path, string name, int defaultValue)
        {
            return (int)ReadValue(type, path, name, defaultValue);
        }

        public static Boolean Exists(RegistryKeyType type, string path)
        {
            Boolean bExist = false;
            RegistryKey rk;            

            if (type == RegistryKeyType.CurrentUser)
            {
                rk = Registry.CurrentUser;
            }
            else
            {
                rk = Registry.LocalMachine;
            }

            RegistryKey registry = rk.OpenSubKey(path);

            if (registry == null) return bExist;
            bExist = true;
            registry.Close();

            return bExist;
        }


        /// <summary>
        /// Reads the value.
        /// </summary>        
        /// <param name="type">The type.</param>
        /// <param name="path">The path.</param>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        internal static object ReadValue(RegistryKeyType type, string path, string name, object defaultValue)
        {
            RegistryKey rk;
            object value=null;

            if (type == RegistryKeyType.CurrentUser)
            {
                rk = Registry.CurrentUser;
            }
            else
            {
                rk = Registry.LocalMachine;
            }

            RegistryKey registry=rk.OpenSubKey(path);
            

            try
            {
                object readValue=registry.GetValue(name);

                if (defaultValue is string && readValue is string[])
                {
                    string[] temp1 = (string[])readValue;

                    if (temp1.Length > 0)
                        value = temp1[0];
                    else
                        value = defaultValue;
                }
                else
                {
                    value = readValue;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Errore duranting read of subkey registry " + name + " of key " + path + ". " + e.Message);
                value = defaultValue;
            }

            if (value == null) value=defaultValue;

            registry.Close();

            return value;
        }

        /// <summary>
        /// Writes the string value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="regKey">The reg key.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void WriteStringValue(RegistryKeyType type, string regKey, string name, string value)
        {
            WriteValue(type, regKey, name, value,RegistryValueKind.String);
        }

        /// <summary>
        /// Writes the string value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="regKey">The reg key.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void WriteMultiStringValue(RegistryKeyType type, string regKey, string name, string[] value)
        {
            WriteValue(type, regKey, name, value, RegistryValueKind.MultiString);
        }

        /// <summary>
        /// Writes the string value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="regKey">The reg key.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void WriteIntValue(RegistryKeyType type, string regKey, string name, int value)
        {
            WriteValue(type, regKey, name, value, RegistryValueKind.DWord);
        }

        /// <summary>
        /// Writes the byte array value.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="regKey">The reg key.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void WriteByteArrayValue(RegistryKeyType type, string regKey, string name, byte[] value)
        {
            WriteValue(type, regKey, name, value, RegistryValueKind.Binary);
        }

        /// <summary>
        /// Writes the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The type.</param>
        /// <param name="regKey">The reg key.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="valueKind">Kind of the value.</param>
        public static void WriteValue<T>(RegistryKeyType type, string regKey, string name, T value, RegistryValueKind valueKind)
        {
            RegistryKey oRegKey = null;

            switch (type)
            {
                case RegistryKeyType.CurrentUser:
                    oRegKey = Registry.CurrentUser;
                    break;
                case RegistryKeyType.LocalMachine:
                    oRegKey = Registry.LocalMachine;
                    break;
            }

            try
            {

                oRegKey = oRegKey.OpenSubKey(regKey, true);
                oRegKey.GetValue(name);
                Debug.WriteLine("Leggo " + name);
                oRegKey.SetValue(name, value, valueKind);
            }
            finally
            {
                oRegKey.Close();
            }

        }


    }
}
