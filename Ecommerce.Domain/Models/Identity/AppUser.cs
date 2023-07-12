using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain
{
    public class AppUser : IdentityUser
    {
        public string displayName { get; set; }
        // public Address Address { get; set; }
    }
}
