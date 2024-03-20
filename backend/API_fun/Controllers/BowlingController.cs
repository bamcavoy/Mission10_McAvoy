using API_fun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_fun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingController(IBowlingRepository tmp) { 
            _bowlingRepository = tmp;
        }

        [HttpGet]
        public IEnumerable<Bowlers> Get()
        {
            var bowlerData = _bowlingRepository.Bowlers.ToArray();

            // Fetch the team information for each bowler
            foreach (var bowler in bowlerData)
            {
                bowler.Team = _bowlingRepository.Teams.FirstOrDefault(t => t.TeamID == bowler.TeamID);
            }

            return bowlerData;
        }
    }
}
