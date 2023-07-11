using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;
using Ecommerce_Api.Domain.Models;


namespace Ecommerce_Api.Domain
{
    public class Product : ISoftDeleted
    {
    //SKU (Stock Keeping Unit) is a unique identifier for a product or item that is used in inventory management and tracking.
    public Guid sku { get; set; }
    public required string name {get; set;}
    public int categoryId{set; get;}
    public int brandId { get; set; }

    // Image: The URL of the product's image.
    public required string thumbNail { get; set; }
     public List<Image>? images { get; set; }


    // Dimensions: The dimensions of the product, used for shipping and handling calculations.
    public float price{get; set;}
    public int stock { get; set; }
    public string? dimensions {get; set;}

    // Weight: The weight of the product, used for shipping and handling calculations.
    public string? weight  {get; set;}
    public string? description {get; set; }


    // CreatedDate: The date and time when the product was created.
    public DateTime createdDate {get; set;}
    // ModifiedDate: The date and time when the product was last modified.
    public DateTime modifiedDate {get; set;}

     // IsActive: A flag indicating whether the product is active.
    public bool? isActive {get; set;}  
     
    // IsFeatured: A flag indicating whether the product is featured.
    public bool? isFeatured{get; set;}
    // Taxable: A flag indicating whether the product is subject to sales tax.
    public bool isTaxable{get; set;}
    public bool isDeleted { get; set;}


    // Variants: A list of product variants, each with its own SKU, price, and attributes.
    public List<Product>? variants {get; set;}

    // Reviews: A list of customer reviews for the product.
    public List<CustomerReview>? reviews{get;set;}

    // Tags: A list of tags associated with the product, used for search and filtering.
    public List<string>? tags {get; set;}

    // RelatedProducts: A list of related products, used for cross-selling and upselling.
    public List<Product>? relatedProducts{get; set;}

    }
}