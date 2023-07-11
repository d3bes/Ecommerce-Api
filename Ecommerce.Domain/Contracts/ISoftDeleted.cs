using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Api.Domain.Contracts
{
    public interface ISoftDeleted
    {
    public bool isDeleted{ get; set;}

    }
}