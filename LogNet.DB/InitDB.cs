using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogNet.DB
{
   public    class InitDB
    {
       public static void Init()
       {
           var db = new SQLiteConnection("logdb");
           db.CreateTable<Logs>();
       }
    }    
}
