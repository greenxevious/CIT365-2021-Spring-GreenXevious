using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myScriptureJournal.Models;

namespace myScriptureJournal.Pages
{
    public class Index1Model : PageModel
    {
        public void OnGet()
        {

        }
        public scripturemodel list { get; set; }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid ==false)
            { return Page(); }

            // return to my database

            
            return RedirectToPage("/scripturelibarylist");
}
    }
}
