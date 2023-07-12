using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;

namespace Ecommerce_Api.Domain
{
    public class Customer:ISoftDeleted
    {
// Id: An identifier for the customer.
// FirstName: The first name of the customer.
// LastName: The last name of the customer.
// Email: The email address of the customer.
// Password: The password for the customer's account.
// ShippingAddress: The customer's shipping address.
// BillingAddress: The customer's billing address.
// Orders: A list of orders placed by the customer.  

    public Guid id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    

  public bool isDeleted { get ; set ; } 
    }
}