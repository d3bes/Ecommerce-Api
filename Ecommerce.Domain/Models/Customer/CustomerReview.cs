using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;

namespace Ecommerce_Api.Domain
{
    public class CustomerReview: ISoftDeleted
    {
    public string? ReviewerName { get; set; }
    public int Rating { get; set; }
    public string? Comments { get; set; }
    public DateTime ReviewDate { get; set; }
    public bool isDeleted { get ; set ; }
    }
}