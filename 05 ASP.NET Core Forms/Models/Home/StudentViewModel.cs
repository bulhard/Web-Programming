using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ASP.NET_Core_Forms.Models.Home
{
    public class StudentViewModel
    {
        [Required]
        public string FirstName { get; set; }
    }
}