using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Coffee_Shop.Models
{
    public class RegisterUser
    {
        [Required] //makes this field required for creating a Users
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Must be between 3 and 30 characters")]
        public string FirstName { get; set; }


        [Required] //makes this field required for creating a Users
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be between 2 and 30 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DOB { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }


        [RegularExpression(@"\d{5}", ErrorMessage = "US ZipCodes only.")]
        public int ZipCode { get; set; }

     

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$", ErrorMessage = "Please enter valid Email") ]
        public string Email { get; set; }

         //Password Length 8
        // Require Unique Chars
        //Require Digit
        // Require Lower Case
        //Require Upper Case
        [Required]
        [RegularExpression (@"^(?!.*([A - Za - z0 - 9])\1{1})(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Please enter valid password")] 
        public string Password { get; set; }

    }
}
