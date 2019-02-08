using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EntApp1.Pages
{
    public class TimeModel : PageModel
    {

        public string[] DayNames { get; set; } = { "Mon", "Tues", "Wed", "Thurs", "Fri" };

        [BindProperty]
        public bool[] IsDayChosen { get; set; } = new bool[5];

        [BindProperty]

        public string[] MonthsChosen { get; set; } = { };

        public List<SelectListItem> MonthsSelectList { get; set; } =

            new List<SelectListItem>
            { new SelectListItem ("Jan", "Jan" ),
               new SelectListItem ("Feb", "Feb" ),
               new SelectListItem ("March", "March" ),
                new SelectListItem ("April", "April" ),
                new SelectListItem ("May", "May" ) };


        public void OnGet()
        {

        }
    }
}