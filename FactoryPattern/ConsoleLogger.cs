using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartupDialogue()
        {
            Console.WriteLine($"Put key in ignition!");
            Thread.Sleep(1000);
            Console.WriteLine($"Turn key!");
            Thread.Sleep(1000);
        }
    }
}
