using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FootballApp.Models;

namespace FootballApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {

        private readonly ILogger<TeamController> _logger;

        public TeamController(ILogger<TeamController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Team[] Get()
        {
            Team team1 = new Team();
            team1.name = "Smith";
            team1.colour = "Orange";
            Team team2 = new Team();
            team2.name = "Baker";
            team2.colour = "White";
            List<Team> AllTeams = new List<Team> { team1, team2 };
            return AllTeams.ToArray();
        }
    }
}
