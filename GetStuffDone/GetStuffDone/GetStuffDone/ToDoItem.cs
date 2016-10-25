using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStuffDone
{
    public class ToDoItem
    {
        public string Name { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsArchived { get; set; }

        public ToDoItem(string name, string priority, DateTime dueDate, bool isArchived)
        {
            Name = name;
            Priority = priority;
            DueDate = dueDate;
            IsArchived = isArchived;
        }
    }
}
