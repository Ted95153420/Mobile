using GetStuffDone.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using GetStuffDone.WinPhone;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_WinPhone))]
namespace GetStuffDone.WinPhone
{
    public class SQLite_WinPhone : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
