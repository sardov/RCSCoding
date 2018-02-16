using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolistapp
{
    class TodoList
    {
        public TodoList()
        {
            todoEntries = new List<string>();
        }
        List<string> todoEntries;

        public void AddNewTodo(string task)
        {


            Console.WriteLine("uzdevums pievienots " + task);
            todoEntries.Add(task);

        }
        
        public void ShowAllTodos()
        {
            //izgustam pirmo elementu no saraksta izmantojot indeksatoru 
            for (int skaititajs = 0; skaititajs <todoEntries.Count; skaititajs = skaititajs + 1)
            {
                Console.WriteLine("your todo list entry is " + todoEntries[skaititajs]);
            }
            
        }
    }
}
