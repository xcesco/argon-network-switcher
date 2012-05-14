using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;


namespace Argon.OperatingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterManagerTest test = new PrinterManagerTest();

            test.Test01();
            Console.ReadKey();
        }
    }
}
