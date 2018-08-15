using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CloudASPWebApp.App_Start
{
    public class CustomFilter : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //string userId = HttpContext.Current.User.Identity.Name;
            //if (userId != null)
            //{
            //    var result = false;
            //    if (!result)
            //    {
            //        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary{{ "controller", "Account" },
            //                              { "action", "Login" }
            //                             });
            //    }
            //}
            //else
            //{
            //    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary{{ "controller", "Account" },
            //                              { "action", "Login" }
            //                             });

            //}
            base.OnActionExecuting(filterContext);
        }
    }
}