using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskMonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Task Monitoring App");
            Console.WriteLine("Select a option");
            Console.WriteLine("1 Add Task");
            Console.WriteLine("2 Display task by Duedate");
            Console.WriteLine("3 View all tasks");
            Console.WriteLine("4 Search for Task by name");
            Console.WriteLine("Press 'x' to ext the program");

            var userInput = Console.ReadLine();

            var taskList = new TaskList();

            while (true)
            {
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("Task name:");
                        var name = Console.ReadLine();

                        Console.WriteLine("Task duedate:");
                        var duedate = Console.ReadLine();

                        var newTask = new Task(name, duedate); 
                        taskList.AddTask(newTask);
                        
                        break;
                    case "2":
                        Console.WriteLine("Task duedate to search:");
                        var searchDuedate = Console.ReadLine();
                        taskList.DisplayTask(searchDuedate);

                        break;
                    case "3":
                        taskList.DisplayAllTask();
                        break;
                    case "4":
                        Console.WriteLine("Task search pharse");
                        Console.ReadLine();
                        break;
                    case "x":
                        return  ;
                    default:
                        Console.WriteLine("Select vaild option");
                        break;
                }
                Console.WriteLine("Select Option");
                userInput = Console.ReadLine();

            }
                    

          
        }
    }
}
