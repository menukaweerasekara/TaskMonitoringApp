using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskMonitoringApp
{
    class TaskList
    {
        private List<Task> _tasks { get; set; } = new List<Task>();

        private void DisplayTaskDetails(Task task)// the task the user addes will be saved here and it 
        {
            Console.WriteLine($"Task: {task.TaskName}, {task.Duedate}");//this will be how the details will be displayed taskname first and then the duedate.
        }

        private void DisplayTasksDetails(List <Task> tasks)
        {
            foreach (var task in tasks)
            {
                DisplayTaskDetails(task);

            }

        }

        public void AddTask(Task task)//this will allow the user to add task 
        {
            _tasks.Add(task);
        }

        public void DisplayTask(DateTime duedate)//this part will allow the user to search for by the duedate
        {
            var task = _tasks.FirstOrDefault(t => t.Duedate == duedate);
            if (task == null)
            {
                Console.WriteLine("Task not found");//if the date you type isn't found this will display
            }
            else
            {
                DisplayTaskDetails(task);//if it is found this display all matching task to that duedate
            }
            
        }

        public void DisplayAllTask()//this will show all the task to the user.
        {
            DisplayTasksDetails(_tasks);
        }

        public void DisplayMatchingTasks(string searchPhrase)//this part will tell let the user search a task it's name
            //if the task user searches matches a task the user added it will show the task with the duedate.
        {
            var matchingTasks = _tasks.Where(t => t.TaskName.Contains(searchPhrase)).ToList();
            DisplayTasksDetails(matchingTasks);//this show results to anything that matches the word you type.
        }

       
    }

}
