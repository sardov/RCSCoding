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
            int guessableNumber = diceNumberGenerator.Next(1, maxNumber);
            Console.WriteLine("Meginiet uzminet");
            int guess = int.Parse(Console.ReadLine());

            if (guess == guessableNumber)
            {
                Console.WriteLine("Apsveicu skaitlis minets pareizi" + guessableNumber);
            }

            else
            {
                Console.WriteLine("");
            }
        }
    }
}

