using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;
using Ecommerce_Api.Domain.Models;

namespace Ecommerce_Api.Domain
{
    public class Brand : ISoftDeleted
    {


    public int id { get; set; }
    public required string name {get; set;}

    //LogoUrl: The URL of the brand's logo.
    public string? logoUrl { get; set; }

    // WebsiteUrl: The URL of the brand's website.
    public string? brandWebsiteUrl {get; set;}
    public string? brandProfileUrl {get; set;}

    // MetaTitle: The title tag for the brand page used for SEO.
     public string? MetaTitle { get; set; }

    // MetaDescription: The meta description tag for the brand page used for SEO.
    public string? MetaDescription { get; set; }
    public  bool isDeleted { get; set;}


    public List<Product>? products {get; set; }

    }


}