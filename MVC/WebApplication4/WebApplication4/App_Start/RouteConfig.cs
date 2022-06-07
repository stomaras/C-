using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*
             * Which specifies that aany URL that starts with domainName/students, must be handled by the StudentController
             * Notice that we haven't specified {action} in the URL pattern because we want every URL that starts with Students 
             * should always use the Index() action to handle any URL request, which starts from domainname/students
             * 
             * 
             */
            routes.MapRoute(
                name: "Student",
                url: "students/{id}",
                defaults: new { controller = "Student", action = "Index" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            /*
             * if you give a non-numeric value for id parameter, then that request will be handled by another route , if there are no 
             * matching routes, then "The resource could not be found" error will be thrown.
             */
            routes.MapRoute(
                name: "Student",
                url: "student/{id}/{name}/{standardId}",
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, standardId = UrlParameter.Optional },
                constraints: new { id = @"\d+"}
            );
        }
    }
}
