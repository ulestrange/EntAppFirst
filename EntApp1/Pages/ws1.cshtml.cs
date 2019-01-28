using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.Pages
{
    public class ws1Model : PageModel
    {

        public string[] MyTestArray { get; set; } 
            = { "England", "Ireland", "Scotland", "Wales" };

        public string Message { get; set; } = "";

        public void OnGet()
        {

        }

        public void OnPost (string firstname)
        {
            Message = $"Hello {firstname}";
        }
    }
}