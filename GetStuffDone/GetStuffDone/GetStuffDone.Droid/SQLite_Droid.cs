using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GetStuffDone.Data;
using SQLite.Net;
using System.IO;
using SQLite.Net.Platform.XamarinAndroid;
using GetStuffDone.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(SQLite_Droid))]
namespace GetStuffDone.Droid
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "//ToDo.db";
            File.Open(path, FileMode.OpenOrCreate);
            SQLitePlatformAndroid androidPlatform = new SQLitePlatformAndroid();
            SQLiteConnection conn  = new SQLiteConnection(androidPlatform, path);
            return conn;

        }
    }
}