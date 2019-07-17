using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ViewResult GetProductsById(int id)
        {
            using (var context = new ShopContext())
            {
                if(context.Products.Count() == 0)
                {
                    context.Products.Add(new Product("Колбаса",500,"Еда"));
                    context.Products.Add(new Product("Диван", 20500, "Мебель"));
                    context.Products.Add(new Product("Iphone X", 500000, "Електроника"));
                    context.Products.Add(new Product("Gucci Suit", 1200000, "Одежда"));
                    context.SaveChanges();
                }                                
            }            
                using (var context = new ShopContext())
                {
                    var goods = context.Products.Where(item => item.Category.Id == id).ToList();
                    ViewBag.Products = goods;
                    ViewBag.Categories = context.Categories.ToList();
                }            
            ViewBag.Title = "MyShop.org";
            
            return View();
        }

        public ViewResult GetProducts()
        {
            using (var context = new ShopContext())
            {
                if (context.Products.Count() == 0)
                {
                    context.Products.Add(new Product("Колбаса", 500, "Еда"));
                    context.Products.Add(new Product("Диван", 20500, "Мебель"));
                    context.Products.Add(new Product("Iphone X", 500000, "Електроника"));
                    context.Products.Add(new Product("Gucci Suit", 1200000, "Одежда"));
                    context.SaveChanges();
                }
            }
            using (var context = new ShopContext())
            {                
                ViewBag.Products = context.Products.ToList();
                ViewBag.Categories = context.Categories.ToList();
            }
            ViewBag.Title = "MyShop.org";

            return View();
        }


        public ViewResult GetProduct(int id)
        {
            using (var context = new ShopContext())
            {
                var currentObject = context.Products.Where(item => item.Id == id).ToList()[0];
                ViewBag.currentObject = currentObject;
                ViewBag.Products = context.Products.ToList();
                ViewBag.Categories = context.Categories.ToList();
            }
            return View();
        }

        public ViewResult Login(string error)
        {
            ViewBag.Title = "MyShop.org";
            ViewBag.Message = error;
            return View();
        }

        public ViewResult Register(string error)
        {
            ViewBag.Title = "MyShop.org";
            ViewBag.Message = error;
            return View();
        }

        public ViewResult AddProduct()
        {
            ViewBag.Title = "MyShop.org";
            ViewBag.Message = "";
            return View();
        }
    }
}