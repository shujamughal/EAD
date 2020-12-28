using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lectrure54_middleware
{
    public class MySecondMiddleWare
    {
        private RequestDelegate next;

        public MySecondMiddleWare(RequestDelegate nextDelegate)
        {
            this.next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Query["custom"].Equals("true")) {
                await context.Response.WriteAsync("I am in second classbased middleware");
            }
            
            await next(context);
        }
    }
}
