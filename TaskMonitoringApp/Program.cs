using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskMonitoringApp
//welcome to the program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\t\t\tWelcome to the Task Monitoring App\t");
            Console.WriteLine("\t\t\t\t__________________________________\t");//Welcoming the user to the app
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any button to continue");//this will show before the user gets asked any questions to continue you can press any buttons
            Console.ReadLine();
            Console.Clear();//clears the welcome and any button part before join options in the selector screen.This make it more easier to see
            Console.WriteLine("Select a option");//The user can select any of these options.
            Console.WriteLine("1 Add Task");
            Console.WriteLine("2 Display task by Duedate");
            Console.WriteLine("3 View all tasks");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press 'x' to exit the program");//to exit the app the user can press x anytime the user has the option to.
            Console.ForegroundColor = ConsoleColor.Green;



            var userInput = Console.ReadLine();// making userInput a variable

            var taskList = new TaskList();
        
            DateTime searchDuedate = new DateTime();


         
            while (true)//starts a loop
            {
               

                switch (userInput)//starts the switch statment for the usesrs answer in the selector screen
                {
                                      
                    case "1"://for option 1 make new task these will the options the user will be given with

                        Console.WriteLine("Task name:");//add the task name
                        var name = Console.ReadLine();

                        Console.WriteLine("make sure date format is like this:__/__/____)\nand add time if you want to like this (__:__:__ p.m./ a.m.\nTask duedate:");//add a duedate for the task
                       while  (!DateTime.TryParse(Console.ReadLine(), out searchDuedate))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invaild answer try again using this format. (__/__/__)\nand if you want to add time like this(__:__:__ p.m./a.m.)");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        var newTask = new Task(name, searchDuedate);// this will display both of them side by side 
                        taskList.AddTask(newTask);//save it the taskList
                        break;//this will be the end of option 1

                    case "2":// in this option the user can search for task using duedate
                        Console.WriteLine("make sure date format is like this:__/__/____)\nand add time if you want to like this (__:__:__ p.m./ a.m.\nTask duedate search:");//ask user to search for a task by duedate
                      

                        while (!DateTime.TryParse(Console.ReadLine(), out searchDuedate))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invaild answer try again using this format. (__/__/__)\nand if you want to add time like this(__:__:__ p.m./a.m.)\nsearch duedate");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        taskList.DisplayTask(searchDuedate);//this will check all task in the taskList and show matching results. taskList gets the options from the first option
                        break;//end of option 2

                    case "3":// chosing option 3 will allow user to see all the task he/she has added 
                        taskList.DisplayAllTask();//this command will display all the data in taskList
                        break;//end of option 3
                   
                    case "4"://option 4
                        Console.WriteLine("Task search name");//this option will allow the user to type a name and if it matches any name in the taskList it will show
                        var searchPharse = Console.ReadLine();

                        taskList.DisplayMatchingTasks(searchPharse);//this will search the data in taskList and display any matching data
                        break;//end of option 4

                    case "x"://When the user wants to exit the app the user can press x and it will stop the application
                        return  ;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Select vaild option");//if the answer user types is incorrect this will come and tell user to chose right answer
                        Console.WriteLine("Choose a Correct option");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;//end of the this case

                }
                //This will show the user the options again so the user can pick anything he/she wants
                Console.WriteLine("Press any button to see main menu options");
                Console.ReadLine();

                Console.WriteLine("Select a option");
                Console.WriteLine("1 Add Task");
                Console.WriteLine("2 Display task by Duedate");
                Console.WriteLine("3 View all tasks");
                Console.WriteLine("4 Search for Task by name");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press 'x' to exit the program");
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();//this displays the options without skipping to the 
                Console.Clear();//this clears the lines before so the code can be more cleaner when you do the other tasks.




            }
                    

          
        }
    }
}
