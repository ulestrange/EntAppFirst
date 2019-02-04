using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EntApp1.Pages
{
    public class GeographyModel : PageModel
    {

        [BindProperty]

        public ProvincesSelected[] Provinces { get; set; }
        = {new ProvincesSelected("Connaught", false),
            new ProvincesSelected("Leinster", false),
            new ProvincesSelected("Ulster", false),
            new ProvincesSelected("Munster", false)
        };


        //public string[] ProvinceList { get; set; }
        //    = { "Connaught", "Leinster", "Munster", "Ulster" };

        public List<SelectListItem> CountyList { get; set; } =

            new List<SelectListItem>
            { new SelectListItem ("Sligo", "Sligo" ),
               new SelectListItem ("Letrim", "Leitrim" ),
                              new SelectListItem ("Mayo", "Mayo" ),
                                             new SelectListItem ("Galway", "Galway" ),
                                                            new SelectListItem ("Roscommon", "Roscommon" ) };



        //[BindProperty]
        //public bool[] ProvinceChoice { get; set; } = new bool[4];

        [BindProperty]
        public string[] ChosenCounties { get; set; } = { };

        public string Message { get; set; } = "";

        public void OnGet()
        {


        }

        public void OnPost()
        {


        }


    }


}