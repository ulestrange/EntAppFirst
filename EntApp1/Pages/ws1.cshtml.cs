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

        public string Message2 { get; set; } = "";

        public string Message3 { get; set; } = "";

        public void OnGet()
        {

        }

        public void OnPost(string firstname, int Number1, int Number2, string operation)
        {
            Message = $"Hello {firstname}";

            Message2 = $"{Number1} plus {Number2} equals {Number1 + Number2}";

            switch (operation)
            {
                case "plus":
                    Message3 = $"{Number1} plus {Number2} equals {Number1 + Number2}";
                    break;
                case "minus":
                    Message3 = $"{Number1} minus {Number2} equals {Number1 - Number2}";
                    break;
                case "multiply":
                    Message3 = $"{Number1} multipled by {Number2} equals {Number1 * Number2}";
                    break;
                case "divide":
                    float Num2 = (float)Number2; // necessary because result might not be an integer
                    Message3 = $"{Number1} divided by {Number2} equals {Number1 / Num2}";
                    break;
            }
        }
    }
}
