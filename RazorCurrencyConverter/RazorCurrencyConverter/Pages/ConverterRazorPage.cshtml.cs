using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{

    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.Mvc;

    namespace RazorCurrencyConverter.Pages
    {
        public class ConverterRazorPageModel : PageModel
        {
            public const double GBP_TO_EUR = 1.00;

            [BindProperty]
            public double InputGBP { get; set; }
            [BindProperty]
            public double OutputEUR { get; set; }

            public void OnGet()
            {

            }
            public void OnPost()
            {
                if (double.IsNegative(InputGBP))
                {
                    ViewData["Message"] = "Invalid negative number! Enter a positive number";
                }
                else
                {
                    OutputEUR = InputGBP * GBP_TO_EUR;
                }
            }
        }

    }
}