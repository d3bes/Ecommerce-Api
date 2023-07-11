namespace Ecommerce_Api.Domain
{
    public enum PaymentStatus
    {
        
        /// Pending
        Pending = 10,

        
        /// Authorized
        Authorized = 20,

        
        /// Paid
        Paid = 30,

        
        /// Partially Refunded
        PartiallyRefunded = 35,

        
        /// Refunded
        Refunded = 40,

        
        /// Voided
        Voided = 50
    }
}