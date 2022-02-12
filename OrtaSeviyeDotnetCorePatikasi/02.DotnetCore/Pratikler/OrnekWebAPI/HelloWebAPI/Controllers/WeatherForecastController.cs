using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWebAPI.Controllers
{
    // Controller'lar:
    // Benzer eylemleri tanımlamak ve gruplamak için kullanılırlar. 
    // Rest mimarisinde Resources'ların karşılığıdır.
    // Geriye HTTP Response dönen yapılardır.

    [ApiController] // Bu controller'ın bir HTTP Response döneceğini taahüt eder.
    [Route("[api/controller]s")] 
    // Route ile, HTTP Requestinin controller içerisindeki bileşenlere nasıl erişebileceklerini söyleriz.
    // WebAPI'ye gelen istekleri Route niteliği ile yönlendiriyoruz diyebiliriz.
    public class WeatherForecastController : ControllerBase 
    {

        // Bu controller için resource: WeatherForecast'tir.
        // Controller'lar, ResourceController şeklinde isimlendirilir.

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) // Dependency Injection
        {
            _logger = logger;
        }

        // Action Metots: Bir resource üzerinde gerçekleştirilebilecek metotlardır.

        [HttpGet] // Bu metodun geriye bir veri döndüreceğini belirtiyor.

        // HTTP Request ile gönderilen parametreler şu şekilde alınabilir:
        // 1. From Body: HTTP Requestin içerisinde gönderilen parametreleri okumak için kullanılır. Genelde HTTP POST ile kullanılır.
        // 2. From Query: URL içerisine gömülen parametreleri okumak için kullanılır. URL'in sonunda '?' işaretinden sonra girilen parametreleri bu şekilde alırız. 
        // 3. From Route 
        public IEnumerable<WeatherForecast> Get() // IEnumerable<x> demek, x tipinte bir listeyi ifade ediyor.
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55), // Next: Random sınıfından rastgele bir sayı üretmemizi sağlayan metot.
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        // From Query
        // api/WeatherForecasts?id=3
        public IEnumerable<WeatherForecast> GetByID([FromQuery] string id)  
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55), 
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        // From Route 
        // api/WeatherForecasts/3
        public IEnumerable<WeatherForecast> GetWeatherCast(string id) 
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55), 
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
