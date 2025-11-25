using System;
using System.Collections.Generic;
using System.Text;

namespace To_DoList
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public TaskItem(string title, string description) 
        { 
            Title = title;
            Description = description;
            IsComplete = false;
        }
    }
}
