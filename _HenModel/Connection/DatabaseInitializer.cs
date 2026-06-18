#region HEADER
//#####################################################################################################################
//###################################  D a t a b a s e I n i t i a l i z e r . c s  ###################################
//#####################################################################################################################
//  FILENAME:  DatabaseInitializer.cs
//  NAMESPACE: HenModel.Connection
//  CLASS(S):  DatabaseInitializer
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the SQLite Database Initializer class.
//---------------------------------------------------------------------------------------------------------------------
//    This class handles:
//      + Checking if DB exists
//      + Creating it if missing
//      + Running CREATE + SEED scripts
//      + Enabling foreign keys
//      + Ensuring idempotency
//=====================================================================================================================
//  AUTHOR:
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//                                                                                                                   !!
//                              A        JJJJJJJJ  PPPPPPP         EEEEEEE  NN     NN   GGGGGG                       !!
//                             AAA          JJ     PP    PP        EE       NNN    NN  GG    GG                      !!
//                            AA AA         JJ     PP    PP        EE       NNNN   NN  GG                            !!
//                           AA   AA        JJ     PPPPPP          EEEEEEE  NN NN  NN  GG   GGGG                     !!
//                          AAAAAAAA   JJ   JJ     PP              EE       NN  NN NN  GG    GG                      !!
//                         AA      AA  JJ   JJ     PP              EE       NN    NNN  GG    GG                      !!
//                        AA        AA  JJJJJJ     PP              EEEEEEE  NN     NN   GGGGGG                       !!
//                                                                                                                   !!
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//    (c)Copyright 2026 AJP Engineering
//    All rights reserved.
//=====================================================================================================================
//  HISTORY:
//    01/01/26 .. AJP Engineering .. Version 1.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenModel.Database.HenStudio;

using Microsoft.Data.Sqlite;

using System;
using System.IO;
using System.Reflection;
#endregion  // REFERENCES

#region namespace HenModel.Connection
namespace HenModel.Connection
{
    #region public static class DatabaseInitializer
    /// <summary>
    /// Database Initializer class.
    /// </summary>
    public static class DatabaseInitializer
    {
        #region public static void Initialize(SQLiteConnectionOptions options)
        /// <summary>
        /// Ensure SQLite Engine is Initialized
        /// </summary>
        /// <param name="options">SQLiteConnectionOptions object</param>
        public static void Initialize(SQLiteConnectionOptions options)
        {
            SQLiteBootstrap.Initialize();

            bool isNewDatabase = !File.Exists(options.DatabasePath);
            if (isNewDatabase)
            {
                CreateDatabase(options);
            }
        }
        #endregion  // public static void Initialize(SQLiteConnectionOptions options)

        #region private static void CreateDatabase(SQLiteConnectionOptions options)
        /// <summary>
        /// Create and seed SQLite Database tables
        /// </summary>
        /// <param name="options"></param>
        private static void CreateDatabase(SQLiteConnectionOptions options)
        {
            string createSql = LoadEmbeddedSql(
                "HenModel.Database.HenStudio.Scripts.Build.Output.00_create_all_henstudio.sql");

            string seedSql = LoadEmbeddedSql(
                "HenModel.Database.HenStudio.Scripts.Build.Output.01_seed_all_henstudio.sql");

            using (var conn = new SqliteConnection(options.BuildConnectionString()))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    // CREATE
                    cmd.CommandText = createSql;
                    cmd.ExecuteNonQuery();

                    // SEED
                    cmd.CommandText = seedSql;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion  // private static void CreateDatabase(SQLiteConnectionOptions options)

        #region private static string LoadEmbeddedSql(string resourceName)
        /// <summary>
        /// Load Enbedded Resourcel String
        /// </summary>
        /// <param name="resourceName">Resource string name</param>
        /// <returns>Embedded Resource string</returns>
        private static string LoadEmbeddedSql(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    throw new InvalidOperationException(
                        "Embedded SQL resource not found: " + resourceName);

                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        #endregion  // private static string LoadEmbeddedSql(string resourceName)
    }
    #endregion      // public static class ConnectionString
}
#endregion      // namespace HenModel.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
