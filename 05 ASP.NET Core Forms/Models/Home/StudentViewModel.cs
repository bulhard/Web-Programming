using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ASP.NET_Core_Forms.Models.Home
{
    public class StudentViewModel
    {
        [Display(Name = "First Name: ")]
        [Required(ErrorMessage = "Please fill first name"), MaxLength(10, ErrorMessage = "Too big, please reduce!")]
        public string FirstName { get; set; }

        [Display(Name = "Is Active: ")]
        public bool isActive { get; set; }

        public string TextGender { get; set; }

        [Display(Name = "Student gender: ")]
        public Gender StudentGender
        {
            get; set;
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}