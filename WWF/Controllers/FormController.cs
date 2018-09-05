using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WWF.Models;
using WWF.Services;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace WWF.Controllers
{
    public class FormController : Controller
    {

        private readonly FormContext _context;

        public FormController(FormContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(Models.FormData formData)
        {
            
            // extra validation
            if(!ModelState.IsValid)
            {
                return View("Index");
            }


            // generate external reference from [Agency Code][Batch Number]-[Sequence Number]-[Date]-[Gift Suffix]

            // generate external reference data source, set to the Agency Code

            // generate source, a 9 digit code relating to the campaign that elicited the response



            _context.Add(formData);
            var id = formData;
            _context.SaveChanges();
            formData.Signature = DataHelper.SaveSignature(formData.FormDataId, formData.Signature);
            _context.Update(formData);
            _context.SaveChanges();

            return Ok();
        }


        public ActionResult SaveFormsToCSV()
        {          
            var formData = _context.FormSubmissions.ToList();
            string csvValues = DataHelper.EFListToCSV(formData);
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString().PadLeft(2, '0');
            string day = DateTime.Now.Day.ToString().PadLeft(2, '0');

            string date = year + month + day;
            string AgencyCode = "AB";
            string fileName = AgencyCode + "-" + date + ".csv";

            DataHelper.UploadSFTPFile("C:\\Users\\jonny\\Downloads\\" + fileName);

            return File(System.Text.Encoding.ASCII.GetBytes(csvValues), "text/csv", fileName);
        }
    }
}