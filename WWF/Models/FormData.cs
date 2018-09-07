using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WWF.Models.DataTypes;

namespace WWF.Models
{
    public class FormData
    {
        public int FormDataId { get; set; }


        [Display(Name = "Contact Number"), StringLength(255, ErrorMessage = "The phone number is too long")]
        public string ContactNumber { get; set; }

        [Display(Name = "Title"), StringLength(40)]
        public string Title { get; set; }

        [Display(Name = "Forenames"), StringLength(30)]
        public string Forenames { get; set; }

        [Display(Name = "Initials"), StringLength(7)]
        public string Initials { get; set; }

        [Display(Name = "Surname"), Required, StringLength(30)]
        public string Surname { get; set; }

        [Display(Name = "Honorifics"), StringLength(30)]
        public string Honorifics { get; set; }

    
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Birthdate BirthDate { get; set; }

        [Display(Name = "Address Line 1"), Required, StringLength(35)]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2"), StringLength(35)]
        public string AddressLine2 { get; set; }

        [Display(Name = "Address Line 3"), StringLength(35)]
        public string AddressLine3 { get; set; }

        [Display(Name = "Address Line 4"), StringLength(35)]
        public string AddressLine4 { get; set; }

        [Display(Name = "Town"), Required, StringLength(35)]
        public string Town { get; set; }

        [Display(Name = "County"), StringLength(35)]
        public string County { get; set; }

        [Display(Name = "Postcode"), StringLength(10)]
        public string Postcode { get; set; }

        [Display(Name = "Country Code"), StringLength(35)]
        public string CountryCode { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
