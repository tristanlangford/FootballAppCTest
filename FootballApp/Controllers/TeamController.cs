using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FootballApp.Repositories;

namespace FootballApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {

        private readonly ILogger<TeamController> _logger;

        public TeamRepository teamRepository;

        public TeamController(ILogger<TeamController> logger)
        {
            _logger = logger;
            teamRepository = new TeamRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = teamRepository.GetAll();
            return Ok(response);
        }
    }
}
