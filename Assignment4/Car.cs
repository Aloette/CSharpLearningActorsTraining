using System;
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
            else
            {
                Console.WriteLine("the car has no gasoline, please refuel");
            }
        }

        public bool Refuel(int amount)
        {
            gasoline += amount;
            return true;
        }
    }
}
