
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogNet.DB
{
   public class Logs
    {
       [PrimaryKey, AutoIncrement  ]
       public int ID { get; set; }
       public int Type { get; set; }
    }
}
