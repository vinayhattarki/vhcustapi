using System;

namespace vhcustapi
{
    public class Customer
    {
        public int number { get; set; }

        public string Gender {get; set;}
        public bool Checking {get; set;}
        public bool Saving {get; set;}
        public bool Mortgage {get; set;}
        public string FirstName { get; set; }
         public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        //public DateTime Date { get; set; }
    }

    public class returnCustomer
    {
        public int number { get; set; }
        public string message { get; set; }
    }
}
