using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WWF.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(Models.FormData formData)
        {
            if(!ModelState.IsValid)
            {
                return View("Index");
            }

            // generate external reference from [Agency Code][Batch Number]-[Sequence Number]-[Date]-[Gift Suffix]
           
            // generate external reference data source, set to the Agency Code

            // generate source, a 9 digit code relating to the campaign that elicited the response
            


            return Ok();
        }
    }
}