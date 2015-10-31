using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace mvc.Models
{
    public class GuestResponse
    {
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "podaj imie i nazwisko:")] //kolejna weryfikacja odbywa sie w widoku
        public string Name { get; set; }
        [Required(ErrorMessage="podaj email")]
       // [EmailAddress]
        public string Email { get; set; }
        [Required()]
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }

    }
}