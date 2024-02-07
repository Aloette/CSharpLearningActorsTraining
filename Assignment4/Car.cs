using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Car : IVehicle
    {
        private int gasoline;
        public Car(int startingGasoline)
        {
            gasoline = startingGasoline;
        }
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving");
            }
        }

        public bool Refuel(int amount)
        {
            gasoline += amount;
            return true;
        }

    //The Refuel method will increase the gasoline
    //of the car and return true.


    }
}
