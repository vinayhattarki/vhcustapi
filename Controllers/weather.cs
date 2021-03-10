using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace vhcustapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;

        public WeatherController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<weather> Get()
        {
            
           var weathersList = new List<weather>() { 
                new weather(){ Day = "Monday", Weather="30F", WeatherStatus="Sunny"},
                new weather(){ Day = "Tuesday", Weather="40F", WeatherStatus="Windy"},
                new weather(){ Day = "Wednesday", Weather="50F", WeatherStatus="Cold"},
                new weather(){ Day = "Thursday", Weather="60F", WeatherStatus="Stormy"},
                new weather(){ Day = "Friday", Weather="70F", WeatherStatus="Sunny"},
                new weather(){ Day = "Saturday", Weather="10F", WeatherStatus="Sunny"},
                new weather(){ Day = "Sunday", Weather="20F", WeatherStatus="Sunny"},
            };

            return weathersList;
        }

        [HttpPost]
         public string Post(string name)
        {
            //List<returnCustomer> listPosted = new List<returnCustomer>();
            //listPosted.Add(new returnCustomer(){number=1,message="posted 1"});
            //listPosted.Add(new returnCustomer(){number=2,message="Posted 2"});

            return "Success Post";
        }

    }
}
