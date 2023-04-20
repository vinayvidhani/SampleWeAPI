using Microsoft.AspNetCore.Mvc;

namespace SampleWeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly List<Person> _persons = new List<Person>()
        {
            new Person() { Id= 1, Name = "Vinay"} ,
            new Person() { Id= 2, Name = "Hridya"},
            new Person() { Id= 3, Name = "Prisha"},
            new Person() { Id= 4, Name = "Kavita"}
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Person> Get()
        {
            // this will return the person list which we have created above
            return _persons;
        }
    }
}