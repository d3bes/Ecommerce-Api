namespace Ecommerce_Api.Domain
{
    public enum ShippingStatus
    {
        
        /// Shipping not required
        ShippingNotRequired = 10,

        
        /// Not yet shipped
        NotYetShipped = 20,

        
        /// Partially shipped
        PartiallyShipped = 25,

        
        /// Shipped
        Shipped = 30,

        
        /// Delivered
        Delivered = 40
    }
}