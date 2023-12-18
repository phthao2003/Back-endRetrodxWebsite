using System.Web.Mvc;
using WebApplicationDoAnFinal.Areas.Admin.Controllers;

namespace WebApplicationDoAnFinal.Areas.Admin
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
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "MainAdmin", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}