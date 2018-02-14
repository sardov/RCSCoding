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
            CalculateCircleArea();
        }
        static void CalculateCircleArea()
        // ctrl + k + d = skaists teksts 
        {
            //izveidojam mainigo, kur glabat radiusu
            int radius;
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

        static int GetNumberFromUser(string msg)
        {
            //izvadam fukncijaj iedoto pazinojumu
            Console.WriteLine(msg);
            //nolasam lietotaja iievadi no ekrana un ierkastam teksta mainiga
            string textInput = Console.ReadLine();
            //izveidojam mainigo, kur glabat apalo skaitli
            int parsedNumber;
            //parveidojam ievadito tekstu par skaitli un ierakstam maingajaj
            parsedNumber = int.Parse(textInput);
            return parsedNumber;
        }
    }
}
