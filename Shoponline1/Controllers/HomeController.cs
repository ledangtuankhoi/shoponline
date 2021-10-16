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
        ShopOnlineEntities _db = new ShopOnlineEntities();
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

        public ActionResult getProduct()
        {
            ViewBag.meta = "san-pham";
            var categorys = from table in _db.products
                            where table.hdie == true
                            orderby table.order
                            ascending
                            select table;
            return PartialView(categorys.ToList());
        }

        public ActionResult getProductByBrand()
        {
            ViewBag.meta = "san-pham";
            var categorys = from table in _db.products
                            where table.hdie == true 
                            select table;
            return PartialView(categorys.ToList());
        }


        public ActionResult getNews()
        {
            ViewBag.meta = "tin-tuc-su-kien";
            var posts = from table in _db.News
                        where table.hide == true
                        orderby table.datebegin
                        ascending
                        select table;
            return PartialView(posts.ToList());
        }


        public ActionResult getBrand()
        {
            ViewBag.meta = "hang";
            var view = from table in _db.Brands 
                       select table;
            return PartialView(view);
        }

        public ActionResult text()
        {
            return View();
        }
    }
}