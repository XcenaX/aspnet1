namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication2.Models;

    public class ShopContext : DbContext
    {        
        public ShopContext()
            : base("name=ShopContext")
        {
        }        
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}