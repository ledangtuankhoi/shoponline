using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shoponline1.Models;
 

namespace Shoponline1.Controllers
{
    public class BrandController : Controller
    {

        ShopOnlineEntities _db = new ShopOnlineEntities();
        // GET: Brand
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult detail(String metatitle)
        {
            var view = from table in _db.Brands
                       where table.name == metatitle
                       select table;
            return PartialView(view.FirstOrDefault());
        }

        public ActionResult getProduct(long idBrand)
        {
            var view = from table in _db.Brands
                       where table.id == idBrand
                       select table;
            return PartialView(view.FirstOrDefault());
        }
    }
}