using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;

namespace Ecommerce_Api.Domain
{
    public class WhishList: ISoftDeleted
    {
//         wishlist{
// id , name, user, list<product>, isDefualt
// }
    public int id {set;get;}
    public string name {set;get;}
    public int userId {set;get;}
    public bool isDefualt {set;get;}
    public bool isDeleted { get; set; }

    public List<Product> products{set;get;}

    }
}