using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMonitoringApp
{
    class Task
    {
        public Task (string taskname, string duedate)
        {
            TaskName = taskname;
            Duedate = duedate;
        }
        public string TaskName { get; set; }
        public string Duedate { get; set; }
    }
}
