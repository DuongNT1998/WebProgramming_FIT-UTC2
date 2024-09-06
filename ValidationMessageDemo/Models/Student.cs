using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationMessageDemo.Models
{
    public class Student
    {

        [Required(ErrorMessage ="Id is mandatory !")]
        [StringLength(8,MinimumLength =8, ErrorMessage = "Your ID must have only 8 characteristics!")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory !")]
        public string Name {  get; set; }
        
        [Required(ErrorMessage = "Age is mandatory !")]
        [Range(18,30,ErrorMessage ="Age must be between 18 and 30!")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "PhoneNumber is mandatory !")]
        [StringLength(11, MinimumLength = 10)]
        public string PhoneNumber {  get; set; }

        [Required(ErrorMessage = "Email is mandatory !")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*",ErrorMessage ="Email is not matched the format!")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Password is mandatory !")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$",ErrorMessage ="Password is not matched the format!")]
        public string Password {  get; set; }

        /*[DisplayName("Confirm Password")]
        [Required(ErrorMessage = "ConfirmPassword is mandatory !")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Password is not matched the format!")]
        [Compare("Password",ErrorMessage ="ConfirmPassword and Password is not matched!")]
        public string ConfirmPassword { get; set; }*/

        [Required(ErrorMessage = "Gender is mandatory !")]
        public string Gender {  get; set; }

        [Required(ErrorMessage = "School year is mandatory !")]
        public string SchoolYear { get; set; }

        [Required(ErrorMessage = "Note is mandatory !")]
        public string Note {  get; set; }

        [Required(ErrorMessage ="Faculty is mandatory!")]
        [ReadOnly(true)]
        public string Faculty { get; set; }

       
    }
}