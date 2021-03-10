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
    public class CustomerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Customer
            {
                FirstName = "Vinay",
                LastName = "Hattarki",
                Address = "4982"
            })
            .ToArray();
        }

        // POST: api/values
        // public string Post(Customer cust)
        // {
            
        //     return "sucess okay posted";
        // }

        [HttpPost]
         public Customer Post(Customer objNewCustomer)
        {
            Customer returnCust = new Customer();
            
            returnCust.FirstName = objNewCustomer.FirstName.ToString() ;
            returnCust.LastName =  objNewCustomer.LastName.ToString();
            returnCust.Address =  objNewCustomer.Address.ToString();
            returnCust.City =  objNewCustomer.City.ToString();
            returnCust.State = objNewCustomer.State.ToString();
            returnCust.Gender =  objNewCustomer.Gender.ToString() ;
            returnCust.Checking = objNewCustomer.Checking;
            returnCust.Saving = objNewCustomer.Saving;
            returnCust.Mortgage  = objNewCustomer.Mortgage;
            
            return returnCust;
        }

    }
}
