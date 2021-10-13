using Shoponline1.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Shoponline1.Controllers
{
    public class ProductController : Controller
    {
        ShopOnlineEntities _db = new ShopOnlineEntities();
        // GET: Product
        public ActionResult Index(String meta)
        {
            var productsByCate = from table in _db.categories
                                 where table.meta == meta
                                 select table;

            return View(productsByCate.FirstOrDefault());
        }



        public ActionResult getProductByCate(long id, String metatitle)
        {
            ViewBag.meta = metatitle;

            var products = from table in _db.products
                           where table.hdie == true && table.categoryid == id
                           orderby table.datebegin ascending
                           select table;
            return PartialView(products.ToList());
        }

        public ActionResult getProductByBrand(long brandid, String metatitle)
        {
            ViewBag.meta = metatitle;

            var products = from table in _db.products
                           where table.hdie == true && table.brandid == brandid
                           orderby table.datebegin ascending
                           select table;
            return PartialView(products.ToList());
        }

        public ActionResult getProductDetail(String metatitle)
        {

            var productDetail = from table in _db.products
                                where table.hdie == true && table.meta == metatitle
                                select table;
            return PartialView(productDetail.FirstOrDefault());
        }

        public ActionResult getProductRelated()
        {
            ViewBag.meta = "san-pham";
            var product = from table in _db.products
                          where table.hdie == true
                          select table;
            return PartialView(product.ToList());
        }

    }
}