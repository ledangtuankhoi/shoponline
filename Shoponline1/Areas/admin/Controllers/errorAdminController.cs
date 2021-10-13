using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoponline1.Areas.admin.Controllers
{
    public class errorAdminController : Controller
    {
        // GET: admin/errorAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult page404()
        {
            return View();
        }
    }
}