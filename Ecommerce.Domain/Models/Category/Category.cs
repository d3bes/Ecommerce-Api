using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;
using Ecommerce_Api.Domain.Models;


namespace Ecommerce_Api.Domain
{
    public class Category:ISoftDeleted
    {

    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int? parentCategoryId { get; set; }

    // ChildrenCategories: A list of child categories id's.
    public List<int>? childrenCategoriesIds { get; set; }

     // MetaTitle: The title tag for the brand page used for SEO.
     public string? metaTitle { get; set; }
     
    // MetaDescription: The meta description tag for the brand page used for SEO.
    public string? metaDescription { get; set; }

    public  bool isDeleted { get; set;}

    public List<Product> products { get; set; }


    }
}