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

        public string[] CountyList { get; set; } = { "Sligo", "Letrim", "Mayo", "Galway", "Roscommon" };


        [BindProperty]
        public bool[] ProvinceChoice { get; set; } = new bool[4];

        [BindProperty]
        public string[] ChosenCounties { get; set; } = { };

        public string Message { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ChosenCounties.Length == 0)
            {
                Message = "Your picked no counties";
            }
            else
            {
                Message = $"<ul>";
                foreach (string county in ChosenCounties)
                {
                    Message += $"<li>{county}</li>";
                }

                Message += "<ul>";
            }

        }


    }
}