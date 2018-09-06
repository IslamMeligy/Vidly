using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute Routing
            routes.MapMvcAttributeRoutes();

            ////Convention Routing
            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movies/released/{year}/{month}",
            //    new { Controller = "Movies", Action = "ByReleaseDate" },
            //    new { year = @"2015|2016", month = @"\d{2}" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
