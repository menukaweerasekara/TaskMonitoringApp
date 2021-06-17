using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskMonitoringApp
{
    class TaskList
    {
        private List<Task> _tasks { get; set; }

        private void DisplayTaskDetails(Task task)
        {
            Console.WriteLine($"Task: {task.TaskName}, {task.Duedate}");
        }

        private void DisplayTasksDetails(List <Task> tasks)
        {
            foreach (var task in tasks)
            {
                DisplayTaskDetails(task);

            }

        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public void DisplayTask(string duedate)
        {
            var task = _tasks.FirstOrDefault(t => t.Duedate == duedate);
            if (task == null)
            {
                Console.WriteLine("Task not found");
            }
            else
            {
                DisplayTaskDetails(task);
            }
            
        }

        public void DisplayAllTask()
        {
            DisplayTasksDetails(_tasks);
        }

        public void DisplayMatchingTasks(string searchPhrase)
        {
            var matchingTasks = _tasks.Where(t => t.TaskName.Contains(searchPhrase)).ToList();
            DisplayTasksDetails(matchingTasks);
        }
        //16.25 is time to start
    }

}
