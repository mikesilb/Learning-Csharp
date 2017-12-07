using System;

namespace ThrowKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int everyonesMoney = EveryonesMoney();
        }

        public static int EveryonesMoney()
        {
            int everyonesMoney = 0;

            try
            {
                everyonesMoney = OurMoney(10, 10) + TheirMoney(10, -10);
            }

            catch (Exception ex )
            {
                // Log thinghs in your database
                throw new Exception("Extra Information", ex);
            }
            return everyonesMoney;
        }
        public static int TheirMoney(int hisMoney, int herMoney)
        {
            if (hisMoney < 0 || herMoney < 0) throw new ArithmeticException("His money or her money is not valid");
            return hisMoney + herMoney;
        }
        public static int OurMoney(int myMoney, int yourMoney)
        {
            if (myMoney < 0 || yourMoney < 0) throw new ArithmeticException("My money or your money is not valid");
            return myMoney + yourMoney;   
        }
    }
}
