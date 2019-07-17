using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        public RedirectResult Register(User user)
        {
            if(user.FIO == "" || user.Login == "" || user.Password == "")
            {                
                return Redirect("~/Product/Register/Ошибка! Поля не должны быть пустыми!");
            }
            using(var context = new ShopContext())
            {
                if(context.Users.Where(currentUser => currentUser.Login == user.Login).ToList().Count > 0)
                {                    
                    return Redirect("~/Product/Register/Ошибка! Пользователь с таким логином уже существует!");
                }
                context.Users.Add(user);
                context.SaveChanges();
                return Redirect("~/Product/GetProducts");
            }
        }
    }
}