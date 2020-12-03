using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lecture44_web.pages
{
    public class Index1Model : PageModel
    {

        public string DayName { get; set; }
        public string CurrentTime { get; set; }

        public void OnGet()
        {
            DayName = System.DateTime.Now.ToString("dddd");
            CurrentTime = System.DateTime.Now.ToString();
        }
    }
}
