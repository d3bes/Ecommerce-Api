using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Models;
using Ecommerce_Api.Domain.Contracts;

namespace Ecommerce_Api.Domain
{
    public class Order: ISoftDeleted
    {
        #region  Properties
     
        /// Gets or sets the order identifier

        public Guid OrderGuid { get; set; }

     
        /// Gets or sets the store identifier

        public int brandId { get; set; }

        public int supplierId { get; set; }
        /// Gets or sets the customer identifier

        public int CustomerId { get; set; }

        

     
        /// Gets or sets the billing address identifier

        public int BillingAddressId { get; set; }

     
        /// Gets or sets the shipping address identifier

        public int? ShippingAddressId { get; set; }

     
        /// Gets or sets the pickup address identifier

        public int? PickupAddressId { get; set; }

     
        /// Gets or sets a value indicating whether a customer chose "pick up in store" shipping option

        public bool PickupInStore { get; set; }

     
        /// Gets or sets an order status identifier

        public int OrderStatusId { get; set; }

     
        /// Gets or sets the shipping status identifier

        public int ShippingStatusId { get; set; }

     
        /// Gets or sets the payment status identifier

        public int PaymentStatusId { get; set; }

     
        /// Gets or sets the payment method system name

        public string PaymentMethodSystemName { get; set; }

     
        /// Gets or sets the customer currency code (at the moment of order placing)

        public string CustomerCurrencyCode { get; set; }

     
        /// Gets or sets the currency rate

        public decimal CurrencyRate { get; set; }

     
        /// Gets or sets the customer tax display type identifier

        public int CustomerTaxDisplayTypeId { get; set; }

     
        /// Gets or sets the VAT number (the European Union Value Added Tax)

        public string VatNumber { get; set; }

     
        /// Gets or sets the order subtotal (include tax)

        public decimal OrderSubtotalInclTax { get; set; }

     
        /// Gets or sets the order subtotal (exclude tax)

        public decimal OrderSubtotalExclTax { get; set; }

     
        /// Gets or sets the order subtotal discount (include tax)

        public decimal OrderSubTotalDiscountInclTax { get; set; }

     
        /// Gets or sets the order subtotal discount (exclude tax)

        public decimal OrderSubTotalDiscountExclTax { get; set; }

     
        /// Gets or sets the order shipping (include tax)

        public decimal OrderShippingInclTax { get; set; }

     
        /// Gets or sets the order shipping (exclude tax)

        public decimal OrderShippingExclTax { get; set; }

     
        /// Gets or sets the payment method additional fee (incl tax)

        public decimal PaymentMethodAdditionalFeeInclTax { get; set; }

     
        /// Gets or sets the payment method additional fee (exclude tax)

        public decimal PaymentMethodAdditionalFeeExclTax { get; set; }

     
        /// Gets or sets the tax rates

        public string TaxRates { get; set; }

     
        /// Gets or sets the order tax

        public decimal OrderTax { get; set; }

     
        /// Gets or sets the order discount (applied to order total)

        public decimal OrderDiscount { get; set; }

     
        /// Gets or sets the order total

        public decimal OrderTotal { get; set; }

     
        /// Gets or sets the refunded amount

        public decimal RefundedAmount { get; set; }

     
        /// Gets or sets the reward points history entry identifier when reward points were earned (gained) for placing this order

        public int? RewardPointsHistoryEntryId { get; set; }

     
        /// Gets or sets the checkout attribute description

        public string CheckoutAttributeDescription { get; set; }

     
        /// Gets or sets the checkout attributes in XML format

        public string CheckoutAttributesXml { get; set; }

     
        /// Gets or sets the customer language identifier

        public int CustomerLanguageId { get; set; }

     
        /// Gets or sets the affiliate identifier

        public int AffiliateId { get; set; }

     
        /// Gets or sets the customer IP address

        public string CustomerIp { get; set; }

     
        /// Gets or sets a value indicating whether storing of credit card number is allowed

        public bool AllowStoringCreditCardNumber { get; set; }

     
        /// Gets or sets the card type

        public string CardType { get; set; }

     
        /// Gets or sets the card name

        public string CardName { get; set; }

     
        /// Gets or sets the card number

        public string CardNumber { get; set; }

     
        /// Gets or sets the masked credit card number

        public string MaskedCreditCardNumber { get; set; }

     
        /// Gets or sets the card CVV2

        public string CardCvv2 { get; set; }

     
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

     
        /// Gets or sets the capture transaction identifier

        public string CaptureTransactionId { get; set; }

     
        /// Gets or sets the capture transaction result

        public string CaptureTransactionResult { get; set; }

     
        /// Gets or sets the subscription transaction identifier

        public string SubscriptionTransactionId { get; set; }

     
        /// Gets or sets the paid date and time

        public DateTime? PaidDateUtc { get; set; }

     
        /// Gets or sets the shipping method

        public string ShippingMethod { get; set; }

     
        /// Gets or sets the shipping rate computation method identifier or the pickup point provider identifier (if PickupInStore is true)

        public string ShippingRateComputationMethodSystemName { get; set; }

     
        /// Gets or sets a value indicating whether the entity has been deleted

        public bool isDeleted { get; set; }

     
        /// Gets or sets the date and time of order creation

        public DateTime CreatedOnUtc { get; set; }

     
        /// Gets or sets the custom order number without prefix

        public string CustomOrderNumber { get; set; }

     
        /// Gets or sets the reward points history record (spent by a customer when placing this order)

        public virtual int? RedeemedRewardPointsEntryId { get; set; }

        #endregion

        #region Custom properties

     
        /// Gets or sets the order status

        public OrderStatus OrderStatus
        {
            get => (OrderStatus)OrderStatusId;
            set => OrderStatusId = (int)value;
        }

     
        /// Gets or sets the payment status

        public PaymentStatus PaymentStatus
        {
            get => (PaymentStatus)PaymentStatusId;
            set => PaymentStatusId = (int)value;
        }

     
        /// Gets or sets the shipping status

        public ShippingStatus ShippingStatus
        {
            get => (ShippingStatus)ShippingStatusId;
            set => ShippingStatusId = (int)value;
        }

     
        /// Gets or sets the customer tax display type

        public TaxDisplayType CustomerTaxDisplayType
        {
            get => (TaxDisplayType)CustomerTaxDisplayTypeId;
            set => CustomerTaxDisplayTypeId = (int)value;
        }

        #endregion
    }
}