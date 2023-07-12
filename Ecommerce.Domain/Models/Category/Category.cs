using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;
using Ecommerce_Api.Domain.Models;


namespace Ecommerce_Api.Domain
{
    public class Category:ISoftDeleted
    {

    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
   

     // MetaTitle: The title tag for the brand page used for SEO.
     public string? metaTitle { get; set; }
     
    // MetaDescription: The meta description tag for the brand page used for SEO.
    public string? metaDescription { get; set; }

    public  bool isDeleted { get; set;}

    // Navigation Property
    public List<Product> products { get; set; }

     public  List<Category>? parentCategoryId { get; set; }

    // ChildrenCategories: A list of child categories id's.
    public List<Category>? childrenCategoriesIds { get; set; }



    }
}