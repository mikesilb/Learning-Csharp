using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            if (player.Weapon == Weapons.MachineGun)
            {
                Console.WriteLine("Run!");
            }

            else if (player.Weapon == Weapons.Uzi)
            {
                Console.WriteLine("Give Up");
            }

            else if (player.Weapon == Weapons.HandGun)
            {
                Console.WriteLine("Hide");
            }
        }
    }
    class Player
    {
            public Weapons Weapon { get; set;  }
    }

    public enum Weapons
    {
        HandGun,
        MachineGun,
        Uzi,
        FlameThrower
    }
}
