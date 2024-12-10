using Microsoft.AspNetCore.Mvc;
using timetrackerAPI.services;
using timetrackerAPI.mdoels;

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
        public IActioNResult AddTimePassedByActivity(object obj)
        {
            // Attendus : begin (Time), end (Time), date, idActivity
        }
    }
}