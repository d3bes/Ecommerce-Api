using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Ecommerce_Api.Context;
using Ecommerce_Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Api.Context
{
    public class Context : IdentityDbContext<AppUser>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {



        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=ep-sweet-voice-764690.eu-central-1.aws.neon.tech; Database=Ecommerce; User Id=d3bes;Password=eQ8ku1DWBHYK");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= sql.bsite.net\\MSSQL2016;Initial Catalog=d3bes_Ecommerce; username=d3bes_Ecommerce; password=d3bes;");
        }




        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<CustomerReview> CustomerReviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<WhishList> WhishList { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
