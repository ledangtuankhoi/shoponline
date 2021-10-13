using System.Web.Mvc;
using System.Web.Routing;

namespace Shoponline1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("BrandDetail", "{type}/{metatitle}",
              new { controller = "Brand", action = "detail", metatitle = UrlParameter.Optional },
              new RouteValueDictionary
              {
                    { "type", "hang" }
              },
              namespaces: new[] { "shoponline1.Controllers" });
 

            routes.MapRoute("News", "{type}",
              new { controller = "News", action = "Index", meta = UrlParameter.Optional },
              new RouteValueDictionary
              {
                    { "type", "tin-tuc-su-kien" }
              },
              namespaces: new[] { "shoponline1.Controllers" });


            routes.MapRoute("NewsDetail", "{type}/{metatitle}",
               new { controller = "News", action = "getNewsDetail", metatitle = UrlParameter.Optional },
               new RouteValueDictionary
               {
                    { "type", "tin-tuc-su-kien" }
               },
               namespaces: new[] { "shoponline1.Controllers" });

            routes.MapRoute("ProductByCate", "{type}/{meta}",
              new { controller = "Product", action = "Index", meta = UrlParameter.Optional },
              new RouteValueDictionary
              {
                    { "type", "san-pham" }
              },
              namespaces: new[] { "shoponline1.Controllers" });

            routes.MapRoute("ProductDetail", "{type}/{meta}/{metatitle}",
               new { controller = "Product", action = "getProductDetail", meta = UrlParameter.Optional },
               new RouteValueDictionary
               {
                    { "type", "san-pham" }
               },
               namespaces: new[] { "shoponline1.Controllers" });
 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
