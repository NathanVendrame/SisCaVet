using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SisCaVet.Controllers
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            int? id = ctx.HttpContext.Session.GetInt32("Id");


            if(id == null)
            {
                ctx.Result = new RedirectResult("/Login/Login");
            }
        }
    }
}