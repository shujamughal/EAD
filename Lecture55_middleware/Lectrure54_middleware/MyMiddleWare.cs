using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lectrure54_middleware
{
    public class MyMiddleWare
    {
        private RequestDelegate next;

        public MyMiddleWare(RequestDelegate nextDelegate)
        {
            this.next = nextDelegate;
        }

        public async Task Invoke(HttpContext context) {

            await context.Response.WriteAsync("I am in classbased middleware");
            await next(context);
        }
    }
}
