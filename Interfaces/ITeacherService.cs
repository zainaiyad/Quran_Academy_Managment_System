using QuranAcademyManagmentSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Interfaces
{
    public interface ITeacherService
    {
        string AddTeacher(Teacher teacher);
        string RemoveTeacher(int id);
        string GetTeacher(int id);
        string UpdateTeacher(int id, Teacher teacher);
        List <Teacher> GetAllTeachers();
    }
}
