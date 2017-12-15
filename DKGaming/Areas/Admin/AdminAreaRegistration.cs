using System.Web.Mvc;

namespace DKGaming.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Home",
                "Admin/Home/{action}/{id}",
                new {controller="Home",action = "Index", id = UrlParameter.Optional },
                new[] { "DKGaming.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller="Login",action = "Index", id = UrlParameter.Optional },
                new[] { "DKGaming.Areas.Admin.Controllers" }
            );
        }
    }
}