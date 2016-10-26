using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStuffDone.ViewModel
{
    public class MainPageViewModel
    {
        public void AddTask(string toDo, string priority, DateTime dueDate, int hour,
                            int minute, int second, int updateId, bool isArchived)
        {
            var newToDo = new ToDoItem { Name = toDo, Priority = priority,
                                         DueDate = SetDueDate(dueDate, hour, minute, second),
                                         Id = updateId, IsArchived = isArchived};
            App.DataBase.SaveToDo(newToDo);

        }

        private DateTime SetDueDate(DateTime dueDate, int hour, int minute, int second)
        {
            DateTime returnValue = new DateTime(dueDate.Year, dueDate.Month, dueDate.Day,
                                                hour, minute, second);
            return returnValue;
        }
    }
}
