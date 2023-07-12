namespace Ecommerce_Api.Domain
{
    public class Transaction
    {
        
        /// Gets or sets the card CVV2

        public string CardCvv2 { get; set; }
        
        /// Gets or sets the card type

        public string CardType { get; set; }


        /// Gets or sets the card name

        public string CardName { get; set; }


        /// Gets or sets the card number

        public string CardNumber { get; set; }

        /// Gets or sets the card expiration month

        public string CardExpirationMonth { get; set; }


        /// Gets or sets the card expiration year

        public string CardExpirationYear { get; set; }


        /// Gets or sets the authorization transaction identifier

        public string AuthorizationTransactionId { get; set; }


        /// Gets or sets the authorization transaction code

        public string AuthorizationTransactionCode { get; set; }


        /// Gets or sets the authorization transaction result

        public string AuthorizationTransactionResult { get; set; }

        //Navigation Properties
        public Order? Order { get; set; }
    }
}