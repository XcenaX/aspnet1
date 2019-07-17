using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        public Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = new Category() { Name = category };
        }
        public Product()
        {
            Name = "";
            Price = 0;
            Category = new Category() { Name = "Все" };
        }
    }
}