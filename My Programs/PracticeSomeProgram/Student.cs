using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class Student
    {
        [Required(ErrorMessage = "Student ID is Required")]
        [Range(101, 120, ErrorMessage = "ID Range Should be 101 to 120")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Student Name Is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name Should Be min 3 to 50 letters")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Student Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }




    }
}
