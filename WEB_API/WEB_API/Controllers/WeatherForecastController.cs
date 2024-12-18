using Microsoft.AspNetCore.Mvc;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> FIO = new()
        {
            "Иванов Сергей Петрович", "Смирнова Анна Викторовна", "Кузнецов Алексей Александрович", "Попова Мария Николаевна",
            "Сидоров Дмитрий Андреевич"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<string> Get()
        {
            return FIO;
        }
        [HttpPost]
        public IActionResult Add(string name)
        {
            if (name.Count() > 50)
            {
                return BadRequest("Слишком большое название");
            }
            FIO.Add(name);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(int index, string name)
        {
            if (index < 0 || index >= FIO.Count)
            {
                return BadRequest("Неверный индекс");
            }
            FIO[index] = name;
            return Ok();
        }
        [HttpGet("{index}")]
        public string GetOne(int index)
        {
            string name = FIO[index];
            return name;
        }
        [HttpGet("All")]
        public IActionResult GetAll(int? sortStrategy)
        {
            switch (sortStrategy)
            {
                case null:
                    break;
                case 1:
                    FIO.Sort();
                    break;
                case -1:
                    FIO.Reverse();
                    break;
                default:
                    return BadRequest("Некорректное значение параметра sortStrategy");
            }
            return new OkObjectResult(FIO);
        }
        [HttpGet("find-by-name")]
        public int CountForName(string name)
        {
            int i = FIO.Count;
            int count = 0;
            for (int u = 0; u < i; u++)
            {
                if (name == FIO[u].ToString())
                {
                    count++;
                }
            }
            return count;
        }
        [HttpDelete]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= FIO.Count)
            {
                return BadRequest("Неверный индекс");
            }
            FIO.RemoveAt(index);
            return Ok();
        }
    }
}
