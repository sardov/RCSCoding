using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolistapp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList list = new TodoList();
            while (true)
            {

                //pievienot jaunu daramo lietu
                Console.WriteLine("ludzu ievadiet daramo lietu:");
                string todoTask = Console.ReadLine();
                list.AddNewTodo(todoTask);

                // dzest visas daramas lietas
                // izvadit visas darams lietas uz ekrana
                list.ShowAllTodos();
            }
        }
    }
}
