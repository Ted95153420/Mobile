using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetStuffDone.Data
{
    public class ToDoDataBase
    {
        private SQLiteConnection database;
        static object dbLocker = new object();

        public ToDoDataBase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<ToDoItem>();    
        }

        public ToDoItem GetToDo(int id)
        {
            lock(dbLocker)
            {
                return database.Table<ToDoItem>()
                        .Where(c => c.Id == id)
                        .FirstOrDefault();
            }
        }

        public IEnumerable<ToDoItem> GetToDos()
        {
            lock(dbLocker)
            {
                return (from c in database.Table<ToDoItem>() select c).ToList();
            }
        }

        public int SaveToDo(ToDoItem toDo)
        {
            lock(dbLocker)
            {
                if(toDo.Id != 0)
                {
                    return database.Update(toDo);
                }
                else
                {
                    return database.Insert(toDo);
                }
            }
        }
    }
}
