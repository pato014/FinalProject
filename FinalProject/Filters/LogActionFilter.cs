using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace FinalProject.Filters
{
    public class LogActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            
            Debug.WriteLine($"[Action Executing] Controller: {context.Controller}, Action: {context.ActionDescriptor.DisplayName}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
            Debug.WriteLine($"[Action Executed] Controller: {context.Controller}, Action: {context.ActionDescriptor.DisplayName}, Result: {context.Result}");
        }
    }
}
