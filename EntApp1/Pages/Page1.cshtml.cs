using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [BindProperty]
        [Display(Name = "Second Number")]
        public int? Number2 { get; set; }

        public void OnGet()
        {
            Message = "Hello World from the Get method";
        }

        public void OnPost()
        {
            Message =
                $"{Number1} plus {Number2} equals {Number1 + Number2}";
        }
    }
}