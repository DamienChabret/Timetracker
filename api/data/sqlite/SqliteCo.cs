using System.Data;
using System.Data.Entity;
using System.Data.SQLite;

namespace timetrackerAPI.data.sqlite
{
    public class SqliteCo : ISQL
    {
        private string path = "timetracker.db";
        SQLiteConnection connection;

        public SqliteCo() 
        {
            this.connection = new SQLiteConnection(path);
        }

        public void Open()
        {
            this.connection.Open();
        }

        public void Execute(string request, Dictionary<string,string> parameters = null)
        {
            this.Open();

            SQLiteCommand sqlite_cmd = this.connection.CreateCommand();
            sqlite_cmd.CommandText = request;
            this.AddParameters(sqlite_cmd, parameters);

            sqlite_cmd.ExecuteNonQuery();

            this.Close();
        }

        public DataTable Select(string request, Dictionary<string,string> parameters = null)
        {
            DataTable dt = new DataTable();

            SQLiteCommand sqlite_cmd = this.connection.CreateCommand();
            sqlite_cmd.CommandText = request; 
            this.AddParameters(sqlite_cmd, parameters);

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader); // TO:DO -> Trouver comment renvoyer les données dans dataTable ou autres : Liste de dictionnaire pour remplacer DataTable ?
            }
            this.Close();

            return dt;
        }

        public void Close()
        {
            this.connection.Close();
        }

        public bool TestConnection()
        {
            return true;
        }

        /// <summary>
        /// Gère injection sql
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="parameters"></param>
        private void AddParameters(SQLiteCommand cmd, Dictionary<string, string> parameters)
        {
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
        }
    }
}