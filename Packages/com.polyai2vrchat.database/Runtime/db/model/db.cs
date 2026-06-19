using System.Data;

namespace PolyAI2VRChat.Database.Manager.Models
{
    public class ModelsDatabaseManager : DatabaseManager
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
            return @"CREATE TABLE IF NOT EXISTS Models (modelid INTEGER PRIMARY KEY AUTOINCREMENT, modelname TEXT, modellink TEXT);";
        }

        public void InsertModels(int modelid, string modelname, string modellink)
        {
            IDbCommand cmd = db.CreateCommand();
            cmd.CommandText = "INSERT INTO Models (modelid, modelname, modellink) VALUES (@modelid, @modelname,@modellink)";

            var p1 = cmd.CreateParameter();
            p1.ParameterName = "@modelid";
            p1.Value = modelid;

            var p2 = cmd.CreateParameter();
            p2.ParameterName = "@modelname";
            p2.Value = modelname;

            var p3 = cmd.CreateParameter();
            p3.ParameterName = "@modellink";
            p3.Value = modellink;
            
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            cmd.ExecuteNonQuery();
        }
    }
}