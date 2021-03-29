using _04_Students_Homework.Interfaces;
using _04_Students_Homework.Models.Students;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students_Homework.Services
{
    public class StudentService : IStudentService
    {
        private IList<StudentViewModel> studentList = new List<StudentViewModel>{
                new StudentViewModel() { StudentNumber = 1, FirstName = "John", LastName = "Smith" } ,
                new StudentViewModel() { StudentNumber = 2, FirstName = "Steve",  LastName="Gordon" } ,
                new StudentViewModel() { StudentNumber = 3, FirstName = "Bill",  LastName="CLinton" } ,
                new StudentViewModel() { StudentNumber = 4, FirstName = "Ram" , LastName="Stain" } ,
                new StudentViewModel() { StudentNumber = 5, FirstName = "Ron" , LastName="Sullivan" } ,
                new StudentViewModel() { StudentNumber = 6, FirstName = "Chris" , LastName="Norris" } ,
                new StudentViewModel() { StudentNumber = 7, FirstName = "Rob" , LastName="Roy" }
            };

        public IList<StudentViewModel> GetStudents(string firstName, string lastName)
        {
            return studentList
                .Where(s => (s.FirstName == firstName || firstName == null)
                    && ((s.LastName == lastName || lastName == null)))
                .ToList();
        }

        public StudentViewModel GetStudent(int studentNumber)
        {
            return studentList.Where(s => s.StudentNumber == studentNumber).FirstOrDefault();
        }
    }
}