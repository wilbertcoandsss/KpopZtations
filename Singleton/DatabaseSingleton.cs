using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Singleton
{
    public class DatabaseSingleton
    {
        private static DatabaseNewEntities db = null;

        private DatabaseSingleton()
        {

        }

        public static DatabaseNewEntities getInstance()
        {
            if(db == null) db = new DatabaseNewEntities();
            return db;
        }
    }
}