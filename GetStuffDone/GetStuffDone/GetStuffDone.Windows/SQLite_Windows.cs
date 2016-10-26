using GetStuffDone.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using GetStuffDone.Windows;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Windows))]
namespace GetStuffDone.Windows
{
    public class SQLite_Windows : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
