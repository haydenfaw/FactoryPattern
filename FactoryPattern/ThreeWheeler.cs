﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartupDialogue();
            Console.WriteLine($"Building a new threewheeler!");
        }
    }
}
