using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shoponline1.Models;

namespace Shoponline1.Controllers
{
    public class FooterController : Controller
    {
        ShopOnlineEntities _db = new ShopOnlineEntities();
        // GET: Footer
        public ActionResult Index()
        {
            var v = from t in _db.News
                    select t;
            return PartialView(v);
        }

 
    }
}