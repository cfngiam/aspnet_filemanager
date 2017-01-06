using aspnet_filemanager.Helpers;
using System.Web.Mvc;

namespace aspnet_filemanager.Controllers
{
    public class MainController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controller = HttpContext.Request.RequestContext.RouteData.GetRequiredString("controller");
            string action = HttpContext.Request.RequestContext.RouteData.GetRequiredString("action");

            if (SessionManager.GetUser() == null)
            {
                Response.Redirect("~/Login");
            }
            else
            {
                if (SessionManager.GetUser().IsActive && "User" == controller)
                {
                    filterContext.HttpContext.Response.StatusCode = 667;
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}