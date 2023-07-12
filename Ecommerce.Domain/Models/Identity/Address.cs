using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Api.Domain
{
    public class Address
    {
        public int id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? country { get; set; }
        public string? city { get; set; }
        public string? street { get; set; }
        public string? zipCode { get; set; }


        //geo location informations
        public decimal? latitude { get; set; }
        public decimal? longitude { get; set; }
        // [Required]
        // public string appUserId { get; set; }
        // public AppUser? user { get; set; }
    }
}