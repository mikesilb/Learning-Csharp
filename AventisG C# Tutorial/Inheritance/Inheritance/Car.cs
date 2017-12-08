using System;
namespace Inheritance
{
    class Car
    {
        private int _fuel;

        public Car(int fuel)
        {
            _fuel = fuel;
        }

        public void Drive()
        {
            if (_fuel <= 0)
            {
                Console.WriteLine("Cannot drive Not enough fuel");
            }

            else
            {   
                Console.WriteLine("Driving");
                _fuel--;
            }   
        }

        public void Refuel(int fuel)
        {
            _fuel += fuel;
        }

        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public void CheckFuel()
        {
            Console.WriteLine(_fuel);
        }
    }
}
