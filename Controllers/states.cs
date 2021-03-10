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
    public class StateController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;

        public StateController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<State> Get()
        {
            
           var states = new List<State>() { 
                new State(){ StateId = 1, StateName="Minnesota"},
                new State(){ StateId = 2, StateName="Ohio"},
                new State(){ StateId = 3, StateName="California"},
                new State(){ StateId = 4, StateName="Colorado"},
                new State(){ StateId = 6, StateName="Lousiana"},
                new State(){ StateId = 5, StateName="Geroga"},
                new State(){ StateId = 6, StateName="Arkansas"},
            };

            return states;
        }

    }
}
