using System.Collections.Generic;
using Leaderboard.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.Linq;
using System;

namespace Leaderboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderboardController : ControllerBase
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public LeaderboardController(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        [HttpGet("scores")]
        public IEnumerable<Score> GetScores()
        {
            var db = _connectionMultiplexer.GetDatabase();

            // TODO : Get and return list of scores
            return default;
        }

        [HttpGet("numberOfPlays")]
        public int GetNumberOfPlays()
        {
            var db = _connectionMultiplexer.GetDatabase();

            // TODO : Get and return number of plays
            return default;
        }

        [HttpGet("score/best/{username}")]
        public BestScore GetBestScore(string username)
        {
            var db = _connectionMultiplexer.GetDatabase();

            // TODO : Get and return best score of a player
            return default;
        }

        [HttpPost("save")]
        public bool SaveScore(Score score)
        {
            var db = _connectionMultiplexer.GetDatabase();

            // TODO : Get current leaderboard

            // TODO : Set new leaderboard

            // TODO : Increment number of plays

            // TODO : Get current player best score

            // TODO : Save the new best score of the current player (if possible)

            // TODO : Return true if the score is now in the top 5
            return default;
        }
    }
}
