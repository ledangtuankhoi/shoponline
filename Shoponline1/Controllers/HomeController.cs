using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shoponline1.Models;

namespace Shoponline1.Controllers
{
    public class HomeController : Controller
    {
        ShopOnlineEntities1 _db = new ShopOnlineEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getMenu() { 
        
            var menus = from table in _db.menus 
                        where table.hide == true 
                        orderby table.order 
                        ascending select table;
            return PartialView(menus.ToList());
        }



        public ActionResult getCategory()
        {
            ViewBag.meta = "san-pham";
            var categorys = from table in _db.categories 
                            where table.hide == true 
                            orderby table.order 
                            ascending select table;
            return PartialView(categorys.ToList());
        }


        public ActionResult getNews()
        {
            var posts = from table in _db.News
                        where table.hide == true
                        orderby table.datebegin
                        ascending
                        select table;
            return PartialView(posts.ToList());
        }
         
    }
}