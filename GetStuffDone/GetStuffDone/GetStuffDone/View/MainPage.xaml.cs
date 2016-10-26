using GetStuffDone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GetStuffDone.View
{
    public partial class MainPage : ContentPage
    {
        private List<ToDoItem> _toDoList;
        private MainPageViewModel _vm;
        private int upDateId = 0;

        public MainPage(int id)
        {
            InitializeComponent();
            _vm = new MainPageViewModel();
            BindingContext = _vm;
            _toDoList = new List<ToDoItem>();
            ToDoItem toDo = App.DataBase.GetToDo(id);
            entNewTask.Text = toDo.Name;
            dtDeadlineDate.Date = toDo.DueDate;
            tmDeadlineTime.Time = toDo.DueDate.TimeOfDay;
            upDateId = id;
        }

        public MainPage()
        {
            InitializeComponent();
            _vm = new ViewModel.MainPageViewModel();
            BindingContext = _vm;
        }

        public void OnSave(Object sender, EventArgs args)
        {
            _vm.AddTask(entNewTask.Text,
                        entPriority.Text,
                        dtDeadlineDate.Date,
                        tmDeadlineTime.Time.Hours,
                        tmDeadlineTime.Time.Minutes,
                        tmDeadlineTime.Time.Seconds,
                        upDateId,
                        false);

            ClearInputFields();  
        }

        public void OnCancel(Object sender, EventArgs args)
        {

        }

        public void OnReview(Object sender, EventArgs args)
        {
            ClearInputFields();
            Navigation.PushAsync(new ReviewTasks());
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
