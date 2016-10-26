using System;
using GetStuffDone.Data;
using SQLite.Net;
using GetStuffDone.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_ios))]
namespace GetStuffDone.iOS
{
    public class SQLite_ios : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}