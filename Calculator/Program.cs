using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)

        {
            //CalculateCircleArea();
            CountTwoNubmersTogether();

        }
        static void CountTwoNubmersTogether()
        {
            double firstNumber;
            firstNumber = GetNumberFromUser("ludzu ievadiet pirmo skaitli");
            double secondNumber;
            secondNumber = GetNumberFromUser("ievadiet otro skaitli");
            double result;
            result = firstNumber + secondNumber;
            Console.WriteLine("aprekina rezultats: " + result);
            Console.ReadLine();





        }
        static void CalculateCircleArea()
        // ctrl + k + d = skaists teksts 
        {
            //izveidojam mainigo, kur glabat radiusu
            double radius;
            //izveidosim mainigo kur glabat rezultatu
            double result;
            //pieskirsim raiusa maingajam vertibu
            radius = GetNumberFromUser("ludzu ievadiet radiusu ");
            //veicam aprekinasanas operaciju
            result = radius * radius * 3.14;
            // paradam rezulatu lietotajam
            Console.WriteLine("rezultat " + result);
            Console.ReadLine();
        }

        static double GetNumberFromUser(string msg)
        {
            //izvadam fukncijaj iedoto pazinojumu
            Console.WriteLine(msg);
            //nolasam lietotaja iievadi no ekrana un ierkastam teksta mainiga
            string textInput = Console.ReadLine();
            //izveidojam mainigo, kur glabat apalo skaitli
            double parsedNumber;
            //parveidojam ievadito tekstu par skaitli un ierakstam maingajaj
            bool parseWasSuccess = double.TryParse(textInput, out parsedNumber);
            if (parseWasSuccess == false)
            {
                Console.WriteLine("slikti ievadits skaitlis" + textInput);
                Console.WriteLine("ievadi skaitli velreiz");
                   parsedNumber = GetNumberFromUser(msg);


            }
            else
            {
                Console.WriteLine("briniskigi ievaditsa skaitlis");
            }
            return parsedNumber;

        }
    }
}
