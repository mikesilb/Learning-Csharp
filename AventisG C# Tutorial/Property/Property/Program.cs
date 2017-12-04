using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Lives = 200;

            Console.WriteLine(player.Lives);

        }
    }

    class Player
    {
        private int _lives = 100;
        public int Lives
        {
            get
            {
                return _lives;
            }
            set
            {
                if (value <= 0 || value > 1000)
                {
                    Console.WriteLine("This does not make any sense");
                    return;
                }

                _lives = value;
            }
        }
    }
}
