using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem( decimal price, int quantity) //ProductItemOrdered itemOrdered,
        {
            // ItemOrdered = itemOrdered;
            Price = price;
            Quantity = quantity;
        }
        // public ProductItemOrdered ItemOrdered { get; set; }

        public Guid orderId { get; set; }
        public Guid productId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal? discount { get; set; }

        //Navigation Properties
        public Order order { get; set; }
        public Product product { get; set; }
    }
}
