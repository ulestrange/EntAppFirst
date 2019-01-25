using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.Pages
{
    public class Page1Model : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public int Number1 { get; set; }

        public void OnGet()
        {
            Message = "Hello World from the Get method";
        }

        public void OnPost()
        {
            Message = 
                String.Format("Hello from the Post method  using page model properties number was {0}", Number1);
        }
    }
}