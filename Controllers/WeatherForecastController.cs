using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
     

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]

        public IEnumerable<ModeloEjemplo> get() 
        {

            List<ModeloEjemplo> lst = new List<ModeloEjemplo>();


            lst.Add(new ModeloEjemplo() { id = 15, name = "Pedro", description = "Es alto con los ojos azules" });
            lst.Add(new ModeloEjemplo() { id = 15, name = "mIlton", description = "Es alto " });
            lst.Add(new ModeloEjemplo() { id = 15, name = "Roberto", description = "con los ojos azules" });
            lst.Add(new ModeloEjemplo() { id = 15, name = "Samuel", description = "Es alto con los ojos azules" });



            return lst;


        
        }
    }
}