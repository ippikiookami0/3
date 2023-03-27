using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzzForm FizzBuzz { set; get; }
        //[BindProperty(SupportsGet = true)]
        //public string Alert;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
           
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                if (FizzBuzz.YearOfBirth % 4 == 0)
                {
                    FizzBuzz.Result = "To był rok przestępny.";
                   
                }
                else
                {
                    FizzBuzz.Result = "To nie był rok przestępny.";

                }


                HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(FizzBuzz));
                //return RedirectToPage("./SavedInSession");
              
            }

            return Page();
        }
            
    }
}