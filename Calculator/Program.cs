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
            string usersInput = "0";

            while (usersInput != "x")
            {
                Console.WriteLine("please choose action");
                Console.WriteLine("a - calculate circle area");
                Console.WriteLine("c- count two numbers together");
                Console.WriteLine("g - dalas vai ne");
                usersInput = Console.ReadLine();
                //ja atbilde ir a, tad izsaukt apla funkciju
                //ja atbilde ir c tad izsaukt saskaitisanas fuknciju
                //ctios gadijumos paradit kludas pazinojumu
                //DoesTheNumberDevide ();
                if (usersInput == "a")
                {
                    CalculateCircleArea();
                }
                else if (usersInput == "c")
                {
                    CountTwoNubmersTogether();
                }
                else if (usersInput == "g")
                {
                    DoesTheNumberDivide();
                }
                else if (usersInput == "x")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry,did not understand");
                }
            }

            Console.ReadLine();
        }
        static void DoesTheNumberDivide()
        {
            double dalamais = GetNumberFromUser("ludzu ievadiet dalamo");
            double dalitajs = GetNumberFromUser("ludzu ievadiet dalitaju");
            double modulo = dalamais % dalitajs;
            if (modulo == 0)
            {
                Console.WriteLine("sei skaitli dalas");
            }
            else
            {
                Console.WriteLine("sie skaitli nedalas");
            }
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
        //void nozime ka funkcija neatgriez rezultatu taja vieta kur ta izsaukta
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
