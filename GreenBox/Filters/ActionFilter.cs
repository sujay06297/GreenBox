using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace GreenBox.Filters
{
    public class ActionFilter : IActionFilter
    {
        public bool AllowMultiple => throw new NotImplementedException();

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Action 執行前執行
            context.HttpContext.Response.WriteAsync($"進入Action Filter。 \r\n");

            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {         
                context.HttpContext.Response.WriteAsync($"認證失敗。 \r\n");
            }

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Action 執行後執行
            context.HttpContext.Response.WriteAsync($"離開 Action Filter。 \r\n");
        }


    }
}
