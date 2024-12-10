using System.Collections.Generic;

namespace timetrackerAPI.data
{
    public interface ISQL
    {
        public void Open();
        public string[] Execute(string request, Dictionary<string, string> var);
        public void Close();
        public bool TestConnection();
    }
}