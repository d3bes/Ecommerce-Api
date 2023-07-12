using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain
{
    public class OrderAddress
    {
           public OrderAddress()
        {

        }
        public OrderAddress(string firstName, string lastName, string country, string city, string street) //, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            City = city;
            Street = street;
            // ZipCode = zipCode;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string? ZipCode { get; set; }

        //geo location informations
        public decimal? latitude { get; set; }
        public decimal? longitude { get; set; }

        //Navigation Properties

        public Order? Order{ get; set; }

       
    }
}