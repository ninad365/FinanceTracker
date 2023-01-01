using FinanceTracker.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FinanceTracker
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
                name: "TransactionsRoute",
                url: "TransactionsDetails",
                defaults: new { controller = TransactionsController.Name, action = TransactionsController.ActionDetails });

            routes.MapRoute(
                name: "LoginRoute",
                url: "Users/Login",
                defaults: new { controller = UsersController.Name, action = UsersController.ActionLogin });

            routes.MapRoute(
                name: "LogoutRoute",
                url: "Users/Logout",
                defaults: new { controller = UsersController.Name, action = UsersController.ActionLogout });
        }
    }
}
