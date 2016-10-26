using GetStuffDone.Data;
using GetStuffDone.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GetStuffDone
{
    public class App : Application
    {
        private static ToDoDataBase database;

        public static ToDoDataBase DataBase
        {
            get
            {
                if (null == database)
                {
                    database = new ToDoDataBase();
                }
                return database;
            }
        }

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
