using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shoponline1.Models;

namespace Shoponline1.Controllers
{
    public class NewsController : Controller
    {
        ShopOnlineEntities _db = new ShopOnlineEntities();

        // GET: News
        public ActionResult Index()
        {

            return View();
        }


        public ActionResult getNewsDetail(String metatitle)
        {
            var detail = from table in _db.News
                         where table.hide == true && table.meta == metatitle
                         select table;
            return PartialView(detail.FirstOrDefault());
        }

        public ActionResult getNews()
        {
            ViewBag.meta = "tin-tuc-su-kien";
            var news = from table in _db.News
                         where table.hide == true  
                         select table;
            return PartialView(news.ToList());
        }

        public ActionResult getNewsRelated()
        {
            ViewBag.meta = "tin-tuc-su-kien";
            var news = from table in _db.News
                       where table.hide == true
                       select table;
            return PartialView(news.ToList());
        }

    }
}