using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GetStuffDone.View
{
    public partial class ReviewTasks : ContentPage
    {
        public ReviewTasks()
        {
            InitializeComponent();
        }
        public List<ToDoItem> ToDoItems {
            get;
            private set;
        }

        public void OnTapped(object sender, ItemTappedEventArgs args)
        {
            ToDoItem toDoItem = args.Item as ToDoItem;
            DisplayAlert("Chosen", "You just tapped " + toDoItem.Name, "OK");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstToDoItems.ItemsSource = App.DataBase.GetToDos();
        }
    }
}
