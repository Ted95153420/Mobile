using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GetStuffDone
{
    public partial class MainPage : ContentPage
    {
        private List<ToDoItem> _toDoList;

        public MainPage()
        {
            InitializeComponent();
            _toDoList = new List<ToDoItem>();
        }

        public void OnSave(Object sender, EventArgs args)
        {
            _toDoList.Add(new ToDoItem(entNewTask.Text, entPriority.Text,
                                        SetDueDateTime(dtDeadlineDate.Date,
                                                        tmDeadlineTime.Time.Hours,
                                                        tmDeadlineTime.Time.Minutes,
                                                        tmDeadlineTime.Time.Seconds),
                                        false)
                          );
            ClearInputFields();  
        }

        public void OnCancel(Object sender, EventArgs args)
        {

        }

        public void OnReview(Object sender, EventArgs args)
        {
            ClearInputFields();
            Navigation.PushAsync(new ReviewTasks(_toDoList));
        }

        private DateTime SetDueDateTime(DateTime dueDate, int hours, int minutes, int seconds)
        {
            DateTime deadline;
            deadline = new DateTime(dueDate.Year, dueDate.Month, dueDate.Day, hours, minutes, seconds);
            return deadline;
        }

        private void ClearInputFields()
        {
            entNewTask.Text = entPriority.Text = string.Empty;
            DateTime currentTime = DateTime.Now;
            dtDeadlineDate.Date = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day);
            tmDeadlineTime.Time = new TimeSpan(currentTime.Hour, currentTime.Minute, currentTime.Second);
        }
    }
}
