using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace riderTestWebApi.Uilts
{
    public class LogFilter : ActionFilterAttribute
    {
        private readonly ILogger<LogFilter> _logger;

        public LogFilter(ILogger<LogFilter> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("in");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("out");
        }
    }
}