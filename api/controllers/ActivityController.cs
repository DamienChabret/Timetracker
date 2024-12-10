using Microsoft.AspNetCore.Mvc;
using timetrackerAPI.models;
using timetrackerAPI.services;

namespace timetrackerAPI.controllers
{
    [Route("api/")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private ActivityService activityService;

        public ActivityController()
        {
            this.activityService = new ActivityService();
        }

        [HttpGet("activities")]
        public IActionResult GetActivities()
        {
            return Ok(this.activityService.GetAllActivities());
        }

        [HttpPost("activities")]
        public IActionResult CreateActivity([FromBody] Activity activity)
        {
            return CreatedAtAction(nameof(GetActivities), new { id = activity.ID }, activity);
        }
    }
}