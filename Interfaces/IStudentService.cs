using QuranAcademyManagmentSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Interfaces
{
    public interface IStudentService
    {
        string AddStudent(Student student);
        string RemoveStudent(int id);
        string UpdateStudent (int id, Student student);
        Student GetStudent (int id);
        List <Student> GetAllStudents ();
    }
}
