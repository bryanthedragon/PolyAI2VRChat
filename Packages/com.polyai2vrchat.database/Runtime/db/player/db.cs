using System.Data;

namespace PolyAI2VRChat.Database.Manager.Player
{
    public class PlayerDatabaseManager : DatabaseManager
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
            return @"CREATE TABLE IF NOT EXISTS Players (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT);";
        }

        public void InsertPlayer(int id, string name)
        {
            IDbCommand cmd = db.CreateCommand();
            cmd.CommandText = "INSERT INTO Players (id, name) VALUES (@id, @name)";

            var p1 = cmd.CreateParameter();
            p1.ParameterName = "@id";
            p1.Value = id;

            var p2 = cmd.CreateParameter();
            p2.ParameterName = "@name";
            p2.Value = name;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            cmd.ExecuteNonQuery();
        }
    }
}