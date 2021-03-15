using System.Collections.Generic;

namespace _02_ASP.NET_Introduction.Models.Home
{
    public class StudentsViewModel
    {
        public StudentsViewModel()
        {
            Students = new List<Student>();
        }

        public string Class { get; set; }
        public List<Student> Students { get; set; }
    }
}