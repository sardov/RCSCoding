using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbesGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

           
            {
                //paprasit leitotajam cik lielu skailti vins grib minet
                int maxNUmber = int.Parse(Console.ReadLine());


                //izveidojam mainigo kur glabat skaitlu generatora instanci
                Random diceNumberGenerator;
                //ierakkstam mainigaja jaunziveidotu generatoru
                diceNumberGenerator = new Random();
                //paprasam generatoram iedot skaitli starp 0 7
                //ierakstam rezultatu mainiga
                int diceValue = diceNumberGenerator.Next(1, 7);
                Console.WriteLine("tavs kaulina metiens:" + diceValue);
                int secondDiceValue = diceNumberGenerator.Next(0, 101);
                Console.WriteLine("tavs otrais metiens: " + diceValue);
                Console.ReadLine();
                {
                    Console.WriteLine("Please choose mininum value of guessing number");
                    string minNumber;
                    minNumber = Console.ReadLine();
                    Console.WriteLine("Please choose maximum value of guessing number");
                    maxNUmber = Console.ReadLine();

                }


            }
        }
    }
}
