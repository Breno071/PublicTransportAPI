using Microsoft.AspNetCore.Mvc;
using NRedisStack;
using NRedisStack.RedisStackCommands;
using StackExchange.Redis;

namespace PublicTransportAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("test")]
        public string GetRedisString()
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase db = redis.GetDatabase();
            db.StringSet("foo", "bar");
            Console.WriteLine(db.StringGet("foo")); // prints bar
            var hash = new HashEntry[] {
                new HashEntry("name", "John"),
                new HashEntry("surname", "Smith"),
                new HashEntry("company", "Redis"),
                new HashEntry("age", "29"),
                };
            db.HashSet("user-session:123", hash);

            var hashFields = db.HashGetAll("user-session:123");
            return String.Join("; ", hashFields);
        }    
    }
}