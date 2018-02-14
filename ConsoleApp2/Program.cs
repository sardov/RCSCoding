using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // izsaucam sevis izveidoto funkciju
            SayHello();
            // izsaucam savu otro izveidoto funkciju
            SayHelloToUser();
        }

        static void SayHelloToUser()
        {
            // palūdzam lietotājam ievadīt savu vārdu
            // uzrakstot lūgumu ekrāna
            Console.WriteLine("Please enter your name:");
            // izveidojam mainīgo, kur glabāt lietotāja ievadīto vērtību
            string usersName;
            // paprasam konsolei ievadīt tekstu, saglabajām rezultātu mainīgajā
            usersName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            string age;
            age = Console.ReadLine();



            Console.WriteLine("Labdien, " + usersName + " tavs vecums ir " + age);
                    
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!");
            Console.ReadLine();
        }
    }
}
