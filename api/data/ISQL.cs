using System.Data;

namespace timetrackerAPI.data
{
    public interface ISQL
    {
        public void Open();
        public void Execute(string request, Dictionary<string,string> parameters = null);
        public DataTable Select(string request, Dictionary<string,string> parameters = null);
        public void Close();
        public bool TestConnection();
    }
}