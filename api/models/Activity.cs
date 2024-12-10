namespace timetrackerAPI.models
{
    public class Activity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TimePassedActivity> TimePassed { get;}

        public Activity(){
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.TimePassed = new List<TimePassedActivity>();
        }

        public void AddActivityTime(TimePassedActivity pt){
            this.TimePassed.Add(pt);
        }

        public void RemoveActivity(TimePassedActivity pt){
            this.TimePassed.Remove(pt);
        }
    }
}