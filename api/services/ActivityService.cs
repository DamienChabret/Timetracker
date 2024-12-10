using timetrackerAPI.models;

namespace timetrackerAPI.services
{
    public class ActivityService
    {
        private TimePassedActivityService TimePassedActivityService;
        private List<Activity> activities;

        public ActivityService(){
            this.TimePassedActivityService = new TimePassedActivityService();
            this.activities = new List<Activity>{
                new Activity { ID = 1, Name = "Escalade", Description = "Escalade en salle" },
                new Activity { ID = 2, Name = "Courses", Description = "Courses en extérieur" },
                new Activity { ID = 3, Name = "Gym", Description = "Séance de musculation" }
            };
        }

        public Activity[] GetAllActivities(){
        /*    activities.ForEach(activity =>
            {
                List<TimePassedActivity> pt = TimePassedActivityService.GetTimePassedByActivityID(activity.ID).ToList();
                pt.ForEach(x => activity.AddActivityTime(x));
            });

            return activities.ToArray();
        */


            return [];
        }

    }

}