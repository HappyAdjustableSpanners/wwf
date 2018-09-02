using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WWF.Models
{
    public class FormData
    {
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

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
