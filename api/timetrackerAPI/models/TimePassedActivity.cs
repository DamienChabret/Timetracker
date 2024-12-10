namespace timetrackerAPI.models
{
    public class TimePassedActivity
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Heures / minutes de début 
        /// </summary>
        public Time Begin { get; set; }

        /// <summary>
        /// Heures / minutes de fin
        /// </summary>
        public Time End {get; set;}
        public int IdActivity { get; set; }
    }
}