using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain.Models.Category
{
    public class Tag
    {
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    
    public  bool isDeleted { get; set;}

   
    // Navigation Properties
    public List<Product> Products { get; set; }
    }
}