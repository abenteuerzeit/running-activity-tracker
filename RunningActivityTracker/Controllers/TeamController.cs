using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RunningActivityTracker.Entities;
using RunningActivityTracker.Services;

namespace RunningActivityTracker.Controllers
{

    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost("/team")]
        [Authorize(Roles = "TeamAdmin")]
        public ActionResult CreateTeam([FromBody] string teamName)
        {
            _teamService.CreateTeam(teamName);
            return Ok();
        }

        [HttpPut("/team/members")]
        [Authorize(Roles = "TeamAdmin")]
        public ActionResult AddMember([FromBody] string memberName)
        {
            _teamService.AddMember(memberName);
            return Ok();
        }
    }
}
