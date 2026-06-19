using Microsoft.Data.Sqlite;
using System.Data;
using UnityEngine;

namespace PolyAI2VRChat.Database.Manager.Persona
{
    public class PersonaDatabaseManager : DatabaseManager
    {
        private IDbConnection db;

        public void CreateTables()
        {
            IDbCommand cmd = db.CreateCommand();
            cmd.CommandText = CreateInsertTable();
            cmd.ExecuteNonQuery();
        }

        public string CreateInsertTable()
        {
            return @"CREATE TABLE IF NOT EXISTS Personas (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, bio TEXT);";
        }

        public void InsertPersona(int id, string name, string bio)
        {
            IDbCommand cmd = db.CreateCommand();
            cmd.CommandText = "INSERT INTO Personas (id, name, bio) VALUES (@id, @name, @bio)";

            var p1 = cmd.CreateParameter();
            p1.ParameterName = "@id";
            p1.Value = id;

            var p2 = cmd.CreateParameter();
            p2.ParameterName = "@name";
            p2.Value = name;

            var p3 = cmd.CreateParameter();
            p3.ParameterName = "@bio";
            p3.Value = bio;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            cmd.ExecuteNonQuery();
        }
    }
}