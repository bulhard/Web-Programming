using _04_Students_Homework.Models.Students;
using System.Collections.Generic;

namespace _04_Students_Homework.Interfaces
{
    public interface IStudentService
    {
        IList<StudentViewModel> GetStudents(string firstName, string lastName);

        StudentViewModel GetStudent(int studentNumber);
    }
}