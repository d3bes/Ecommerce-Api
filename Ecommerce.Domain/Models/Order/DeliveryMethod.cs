using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain
{
    public class DeliveryMethod
    {
        public int id { get; set; }
        public string ShortName { get; set; }
        public string DeliveryTime { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        //Navigation properties
        public List<Order> OrderList { get; set; }
    }
}
