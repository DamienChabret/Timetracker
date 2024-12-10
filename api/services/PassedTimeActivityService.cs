using timetrackerAPI.models;

namespace timetrackerAPI.services
{
    public class TimePassedActivityService
    {
        private List<TimePassedActivity> TimePassedActivity;

        public TimePassedActivityService()
        {
            this.TimePassedActivity = new List<TimePassedActivity>
            {
                new TimePassedActivity { ID = 1, IdActivity = 1, Begin = new Time { Hours = 12, Minutes = 3 }, End = new Time { Hours = 13, Minutes = 3 } },
                new TimePassedActivity { ID = 2, IdActivity = 2, Begin = new Time { Hours = 14, Minutes = 15 }, End = new Time { Hours = 16, Minutes = 45 } },
                new TimePassedActivity { ID = 3, IdActivity = 3, Begin = new Time { Hours = 9, Minutes = 30 }, End = new Time { Hours = 10, Minutes = 0 } },
                new TimePassedActivity { ID = 4, IdActivity = 2, Begin = new Time { Hours = 11, Minutes = 45 }, End = new Time { Hours = 15, Minutes = 20 } },
                new TimePassedActivity { ID = 5, IdActivity = 2, Begin = new Time { Hours = 8, Minutes = 10 }, End = new Time { Hours = 18, Minutes = 25 } },
                new TimePassedActivity { ID = 6, IdActivity = 1, Begin = new Time { Hours = 7, Minutes = 5 }, End = new Time { Hours = 19, Minutes = 50 } }
            };
        }

        public TimePassedActivity[] GetTimePassedActivities(){
             return this.TimePassedActivity.ToArray();
        }

        public TimePassedActivity[] GetTimePassedByActivityID(int activityID){
            return this.TimePassedActivity.Where(x => x.IdActivity == activityID).ToArray();
        }

    }

}