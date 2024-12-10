using Npgsql;  
using NpgsqlTypes;
using System.Data;

namespace timetrackerAPI.data.postgrsql
{
    public class PostgrsqlCo : ISQL
    {
        private const string CONX = "Server=localhost;Port=5432;Database=timetracker;User Id=damien;Password=damien;";
        private NpgsqlConnection connection = null;

        public PostgrsqlCo()
        {
            this.connection = new NpgsqlConnection(CONX);
        }
        
        public void Open()
        {
            this.connection.Open();
        }

        /// <summary>
        /// Pour tout insert ou update ou delete de la base de donnée
        /// </summary>
        public void Execute(string request, Dictionary<string,string> parameters = null)
        {
            this.Open();

            NpgsqlCommand myCmd = new NpgsqlCommand(request, this.connection);
            this.AddParameters(myCmd, parameters);

            myCmd.ExecuteNonQuery();
            this.Close();
        }

         public DataTable Select(string request, Dictionary<string,string> parameters = null)
        {
            DataTable MyData = new DataTable();
            this.Open();

            NpgsqlCommand myCmd = new NpgsqlCommand(request, this.connection);
            this.AddParameters(myCmd, parameters);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(myCmd);
            da.Fill(MyData);

            this.Close();
            return MyData;
        }

        public void Close()
        {
            this.connection.Close();
        }

        public bool TestConnection()
        {
            this.Open();
            this.Select("SELECT version();");
            this.Close();
            return true;
        }

        /// <summary>
        /// Gère injection sql
        /// </summary>
        private void AddParameters(NpgsqlCommand myCmd, Dictionary<string, string> parameters)
        {
            foreach(KeyValuePair<string, string> param in parameters) // TO:DO -> Faire un case of avec typeof pour gérer le type de NpgsqlDbType
            {
                NpgsqlDbType dataType = NpgsqlDbType.Varchar;
                myCmd.Parameters.Add(new NpgsqlParameter(param.Key, dataType)).Value = param.Value;
            }
        }
    }
}