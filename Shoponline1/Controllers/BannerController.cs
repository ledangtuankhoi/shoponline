using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shoponline1.Models;

namespace Shoponline1.Controllers
{
    public class BannerController : Controller
    {
        ShopOnlineEntities _db = new ShopOnlineEntities();
        // GET: Banner
        public ActionResult bannerSlider()
        {
            var v = from tabel in _db.Banners
                    where tabel.order <= 2
                    orderby tabel.order ascending
                    select tabel;
            return PartialView(v);
        }
        public ActionResult banner2()
        {
            var v = from tabel in _db.Banners
                    where tabel.order >= 3 && tabel.order <= 5 
                    orderby tabel.order ascending
                    select tabel;
            return PartialView(v);
        }


        public ActionResult banner3()
        {
            var v = from tabel in _db.Banners
                    where tabel.order >= 6 && tabel.order <= 7
                    orderby tabel.order ascending
                    select tabel;
            return PartialView(v);
        }


        public ActionResult banner4()
        {
            var v = from tabel in _db.Banners
                    where tabel.order >= 6 && tabel.order <= 7
                    orderby tabel.order ascending
                    select tabel;
            return PartialView(v);
        }
    }
}