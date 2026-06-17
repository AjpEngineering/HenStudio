using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.Sqlite;

namespace HenModel.Database.HenStudio
{
    public static class SQLiteBootstrap
    {
        private static bool _initialized = false;

        public static void Initialize()
        {
            if (_initialized)
                return;
            //---------------------------------------------------------------------
            //--- REQUIRE: This initializes the native SQLite engine at runtime ---
            //---------------------------------------------------------------------
            SQLitePCL.Batteries_V2.Init();
            _initialized = true;
        }
    }
}
