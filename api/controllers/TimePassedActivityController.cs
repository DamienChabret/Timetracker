using Microsoft.AspNetCore.Mvc;
using timetrackerAPI.services;
using timetrackerAPI.models;

namespace timetrackerAPI.controllers
{
    [Route("api/")]
    [ApiController]
    public class TimePassedActivityController : ControllerBase
    {
        private TimePassedActivityService timePassedService;
       
        public TimePassedActivityController()
        {
            this.timePassedService = new TimePassedActivityService();
        }

        [HttpGet("TimePassedActivity")]
        public IActionResult GetTimePassedActivities()
        {
            return Ok(this.timePassedService.GetTimePassedActivities());
        }

        [HttpGet("TimePassedActivity/{activityID:int}")]
        public IActionResult GetTimePassedByActivityID(int activityID)
        {
            return Ok(this.timePassedService.GetTimePassedByActivityID(activityID));
        }

        [HttpPost("TimePassedActivity")]
        public IActionResult AddTimePassedByActivity(object obj)
        {
            TimePassedActivity activity = new TimePassedActivity();
            /*TimePassedActivity activity = new TimePassedActivity()
            {
                ID = obj.id,
                Date = obj.date,
                Begin = new Time() { Hours = obj.begin.hours, Minutes = obj.begin.minutes },
                End = new Time() { Minutes = obj.end.hours, Hours = obj.end.minutes },
                IdActivity = obj.idActivity
            };*/
            this.timePassedService.AddTimePassedByActivity(activity);
            return Ok();
            // Attendus : begin (Time), end (Time), date, idActivity
        }
    }
}