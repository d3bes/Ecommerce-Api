using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain
{
    public class UserAddress
    {
    public int id { get; set; }

    public bool isDefault { get; set; }
    public Guid userId { get; set; }
    public int addressId { get; set; }


    //Navigation Properties
    public Address Address { get; set; }
    public AppUser User { get;set;}

    }
}