using Microsoft.Data.Sqlite;

using PolyAI2VRChat.Database.Manager.Models;
using PolyAI2VRChat.Database.Manager.Persona;
using PolyAI2VRChat.Database.Manager.Player;

using System.Data;

using UnityEngine;

namespace PolyAI2VRChat.Database.Manager
{

    public interface IDatabaseManager : IDatabase
    {   
        void CreateInsertTables();
        void CreateDatabase();
        void Awake();

        public void SetDatabaseName(string name);

        public void SetDatabasePath(string path);

        public IDbConnection GetDatabaseConnection();

        public void CloseDatabaseConnection();
    }
    public class DatabaseManager : MonoBehaviour
    {
        private IDbConnection db;
        private ModelsDatabaseManager ModelsDB;
        private PersonaDatabaseManager PersonaDB;
        private PlayerDatabaseManager PlayerDB;

        public void Awake()
        {
            string path = "URI=file:" + Application.persistentDataPath + "/game.db";
            db = new SqliteConnection(path);
            db.Open();

            CreateInsertTables();
        }

        public void CreateDatabase()
        {
            string path = "URI=file:" + Application.persistentDataPath + "/game.db";
            db = new SqliteConnection(path);
            db.Open();

            CreateInsertTables();
        }

        public void CreateInsertTables()
        {
            IDbCommand cmd = db.CreateCommand();
            cmd.CommandText = PlayerDB.CreateInsertTable(); // Example of creating player tables
            cmd.CommandText = PersonaDB.CreateInsertTable(); // Example of creating persona tables
            cmd.CommandText = ModelsDB.CreateInsertTable(); // Example of creating model tables

            cmd.ExecuteNonQuery();
        }

        public string DatabaseName { get; private set; }
        public string DatabasePath { get; private set; }

        public void SetDatabaseName(string name)
        {
            DatabaseName = name;
        }

        public void SetDatabasePath(string path)
        {
            DatabasePath = path;
        }

        public IDbConnection GetDatabaseConnection()
        {
            return db;
        }

        public void CloseDatabaseConnection()
        {
            if (db != null)
            {
                db.Close();
                db = null;
            }
        }
    }
}