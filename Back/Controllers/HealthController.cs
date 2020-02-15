using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System;

namespace Leaderboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public HealthController(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        [HttpGet]
        public double Ping()
        {
            var db = _connectionMultiplexer.GetDatabase();

            // TODO : Ping duration in ms
            return default;
        }
    }
}