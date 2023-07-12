using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain
{
    public class Image
    {
        public int Id { get; set; }
        public string ImgURL { get; set; }
        
        // Navigation Properties
        public Product Product { get; set; }
    }
}