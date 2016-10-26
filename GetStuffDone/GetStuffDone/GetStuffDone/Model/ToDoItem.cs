using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStuffDone
{
    public class ToDoItem
    {
        [PrimaryKeyAttribute, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsArchived { get; set; }
    }
}
