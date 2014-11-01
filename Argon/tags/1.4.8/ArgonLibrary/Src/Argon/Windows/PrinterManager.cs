using System;
using System.Management;


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
    /// Summary description for Class1
    /// </summary>
    public abstract class PrinterManager
    {
        /// <summary>
        /// Sets the default printer.
        /// </summary>
        /// <param name="strPrinterName">Name of the STR printer.</param>
        /// <returns></returns>
        public static bool SetDefaultPrinter(string strPrinterName)
        {
            int intRet;
            try
            {
                string path = "win32_printer.DeviceId='" + strPrinterName + "'";
                using (ManagementObject printer = new ManagementObject(path))
                {
                    ManagementBaseObject outParams = printer.InvokeMethod("SetDefaultPrinter", null, null);
                    intRet = (int)(uint)outParams.Properties["ReturnValue"].Value;
                }
            }
            catch
            {
                intRet = 99;
            }

            if (intRet != 99)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
