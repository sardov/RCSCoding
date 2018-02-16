using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("ludzu izvelieties maksimalo skailti");
            int maxNumber = int.Parse(Console.ReadLine());

            Random diceNumberGenerator;
            diceNumberGenerator = new Random();
            int guessableNumber = diceNumberGenerator.Next(1, maxNumber + 1);
            Console.WriteLine("Meginiet uzminet");
            int guess = int.Parse(Console.ReadLine());



            for (int tryCount = 1; tryCount < 3; tryCount = tryCount + 1)
            {

                if (guess == guessableNumber)
                {
                    Console.WriteLine("Apsveicu skaitlis minets pareizi " + guessableNumber);
                    Console.ReadLine();
                    break;
                }

                if (guess < guessableNumber)
                {
                    Console.WriteLine("Megini velreiz, so reiz bija pamaz");
                    guess = int.Parse(Console.ReadLine());


                }
                else if (guess > guessableNumber)
                {
                    Console.WriteLine("Megini velreiz, so reiz bija padaudz");
                    guess = int.Parse(Console.ReadLine());
                }
                if (tryCount == 2)
                {
                    Console.WriteLine("Tu esi zaudejis, pareizs skaitlis bija " + guessableNumber);
                    Console.ReadLine();
                    break;
                }
            }



        }



    }
}

