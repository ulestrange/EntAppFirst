using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.Pages
{
    public class GeographyModel : PageModel
    {

        public string[] ProvinceList { get; set; }
            = { "Connaught", "Leinster", "Munster", "Ulster" };

        [BindProperty]
        public bool[] ProvinceChoice { get; set; } = new bool[4];

        public void OnGet()
        {
        }


    }
}