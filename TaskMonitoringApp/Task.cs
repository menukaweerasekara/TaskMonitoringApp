using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMonitoringApp
{
    class Task//class folder for where TaskName and Duedate are made. the variables are made here.
    {
        public Task (string taskname, DateTime duedate)
        {
            TaskName = taskname;//TaskName can also be written as taskname without caps
            Duedate = duedate;//Duedate can aslo be written as duedate without caps
        }

      

        public string TaskName { get; set; } //saying that TaskName will be a string
        public DateTime Duedate { get; set; }// saying that duedate will be a string



    }
}
