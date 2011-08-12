using System;
using System.Management;


namespace Argon.OperatingSystem
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
