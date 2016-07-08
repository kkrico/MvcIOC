using MvcIOC.Models;
using System.Web.Mvc;

namespace MvcIOC.Filters
{
    public class DebugFilter: ActionFilterAttribute
    {
        private IDebugMessageService debugMessageService;

        public DebugFilter(IDebugMessageService debug)
        {
            debugMessageService = debug;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write(debugMessageService.Message);
        }
    }
}