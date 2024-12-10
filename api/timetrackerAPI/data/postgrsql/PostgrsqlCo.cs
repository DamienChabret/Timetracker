using System.Collections.Generic;
using Npgsql;  
using NpgsqlTypes;

namespace timetrackerAPI.data.postgrsql
{
    public class PostgrsqlCo : ISQL
    {
        private const string CONX = "Server=localhost;Port=5432;Database=timetracker;User Id=damien;Password=damien;";
        private NpgsqlCommand myCmd = null;
        private NpgsqlConnection connection = null;

        public PostgrsqlCo()
        {
            this.connection = new NpgsqlConnection(this.CONX);
        }
        
        public void Open()
        {
            this.connection.Open();
            MyCmd = new NpgsqlCommand(insert, MyCnx);
            MyCmd.Parameters.Add(new NpgsqlParameter("nom", NpgsqlDbType.Varchar)).Value = nom;
            MyCmd.ExecuteNonQuery(); 
        }

        public void Insert(string request, Dictionary<string, string> data = null)
        {
            List<string> result = new List<string>();
            this.Open();
            this.myCmd = new NpgsqlCommand(request, this.connection);

            foreach(KeyValuePair<string, string> d in data)
            {
                NpgsqlDbType dataType = NpgsqlDbType.Varchar;
                // TO:DO -> Faire un case of avec typeof pour gérer le type de NpgsqlDbType
                this.myCmd.Parameters.Add(new NpgsqlParameter(d.Key, dataType)).Value = d.Value;
            }

            this.myCmd.ExecuteNonQuery();
            this.Close();
            return result;
        }

        public void Close()
        {
            this.connection.Close();
        }

        public bool TestConnection()
        {
            this.Open();
            string insert = "SELECT version();";
            this.Execute(insert);
            this.Close();

            return true;
        }
    }
}