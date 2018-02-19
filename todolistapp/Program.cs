using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList list = new TodoList();
            while (true)
            {
                Console.WriteLine("ludzdu izveleties darbibu");
                Console.WriteLine("a- pievienot");
                Console.WriteLine("p -paradit");
                Console.WriteLine("d- dzest");
                Console.WriteLine("dv- dzest visu");
                Console.WriteLine("s - save all");
               
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {
                    case "a":
                        // pievienot jaunu darāmo lietu
                        Console.WriteLine("lūdzu ievadiet darāmo lietu:");
                        string todoTask = Console.ReadLine();
                        list.AddNewTodo(todoTask);
                        break;
                    case "p":
                        // izvadīt visas darāmās lietas uz ekrāna
                        list.ShowAllTodos();
                        break;
                    case "d":
                        // dzēst konkretas lietas
                        Console.WriteLine("ludzu ievadied dzesamo numuru");
                        list.ShowAllTodos();
                        int index = int.Parse(Console.ReadLine());
                        list.DeleteTodo(index - 1);
                        break;

                    case "dv":
                        Console.WriteLine("viss tika nodzeests");
                        list.DeleteAllTodos();

                        break;

                    case "s":
                        list.SaveToFile();

                        break;



                }




            }
        }
    }
}
