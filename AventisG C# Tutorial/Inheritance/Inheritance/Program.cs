using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car porsche911 = new Porsche911(10);
            Car hondaAccord = new HondaAccord(8);
            Car lexusIS250 = new LexusIS250(0);

            porsche911.StartEngine();
            porsche911.Drive();
            porsche911.Honk();

            hondaAccord.Drive();
            hondaAccord.Honk();

            lexusIS250.Drive();
            lexusIS250.Honk();
            lexusIS250.Refuel(10);
            lexusIS250.Drive();

        }
    }
}
