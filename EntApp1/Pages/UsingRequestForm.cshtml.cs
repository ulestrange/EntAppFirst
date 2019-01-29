using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.Pages
{
    public class UsingRequestFormModel : PageModel
    {

        public string Message { get; set; } = "";
        public void OnGet()
        {
            Message = "Hello " + Request.Query["firstname"];

        }

        public void OnPost()
        {

        /* This is not a recommended way to access the values
        submitted in the form. However it does work and is similar to
        what happens in PHP and some other web application frameworks. */


            Message = "Hello " + Request.Form["firstname"];
        }
    }
}