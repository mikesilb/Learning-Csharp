using System;
namespace Inheritance
{
    class Car
    {
        private int _fuel;
        private bool _engineStarted;


        public Car(int fuel)
        {
            _fuel = fuel;
        }

        public void StartEngine()
        {
            _engineStarted = true;
            StarterMotorTurnEngineOver();
        }

        private void StarterMotorTurnEngineOver()
        {
            Console.WriteLine("Starter Motor turn engine Over");
            TurnsTheCrankshaft();
        }

        private void TurnsTheCrankshaft()
        {
            Console.WriteLine("Turns the Crankshaft");
            EngineCycleStarts();
        }
        private void EngineCycleStarts()
        {
            Console.WriteLine("Engine Cycle starts");
            BeginCombustion();
        }

        private void BeginCombustion()
        {
            Console.WriteLine("Begin combustion");
        }

        public void Drive()
        {
            if (_engineStarted)
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

            else 
            {
                Console.WriteLine("Cannot drive.  Please start engine.");
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
