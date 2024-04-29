using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetC_MVCSalleSport
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
    name: "AjouterMembre",
    url: "Membre/Ajouter",
    defaults: new { controller = "Membre", action = "Ajouter" }
);
            routes.MapRoute(
    name: "ListeMembres",
    url: "Membre/Liste",
    defaults: new { controller = "Membre", action = "Liste" }
);


        }
    }
}
