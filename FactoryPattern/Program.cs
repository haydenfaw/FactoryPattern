using System;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfWheels;
            bool isParseable = false;
            do
            {
                Console.WriteLine($"Does your car have 2, 3, or 4 wheels?");
                isParseable = int.TryParse(Console.ReadLine(), out numberOfWheels);
            } while (isParseable == false);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            vehicle.Drive();
        }
    }
}
