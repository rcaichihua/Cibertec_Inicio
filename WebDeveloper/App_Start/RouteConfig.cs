using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //No permite abrir archivos con extensiones.
            //No borrar
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //Los ruteos personalizados deben estar siempre antes que el Default
            //routes.MapRoute(
            //    name: "Razor",
            //    url: "Razor/{id}",
            //    defaults: new { controller = "Razor", action = "Product", id = UrlParameter.Optional }
            //);

            //fecha tienen formato dd-mm-yyyy
            //en vez de mandar un get manda un post
            //mandar obejtos y no parametros
            //localhost:1242/Razor/12-12-2016

            // routes.MapRoute(
            //    name: "RazorId",
            //    url: "Razor/{Id}",
            //    defaults: new
            //    {
            //        controller = "Razor",
            //        action = "EntryId"
            //    }
            //);

            // routes.MapRoute(
            //     name: "RazorDate",
            //     url: "Razor/{date}",
            //     defaults: new
            //     {
            //         controller = "Razor",
            //         action = "EntryDate"
            //     }
            // );

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
