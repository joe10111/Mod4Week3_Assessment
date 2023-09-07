using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CommerceMvc.Controllers
{
    public class BaseController : Controller
    {
         // Create this BaseController class so that currentUser exists in every view that inherits from this class
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var currentUser = Request.Cookies["currentUser"] ?? "No User Loged in";
            ViewBag.CurrentUser = currentUser;
            base.OnActionExecuting(context);
        }
    }
}
