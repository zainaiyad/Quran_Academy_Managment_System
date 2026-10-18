using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagmentSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Services
{
    public class TeacherServices : ITeacherService
    {
        private List <Teacher> teachers = new List<Teacher> ();
        public string AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
            return "Added Successfully";
        }
        public string RemoveTeacher(int id)
        {
            var teacher = teachers.FirstOrDefault(teacher  => teacher.Id == id);
            if (teacher != null)
            {
                teachers.Remove(teacher);
                return "Removed Successfully";
            }
            else
                return "Not Found!";
        }
        public Teacher GetTeacher(int id)
        {
            var teacher = teachers.FirstOrDefault(teacher => teacher.Id == id);
            return teacher;
        }
        public string UpdateTeacher(int id, Teacher teacher)
        {
            var teacherToUpdate = teachers.FirstOrDefault(t => t.Id == id);
            if (teacherToUpdate != null)
            {
                teacherToUpdate = teacher;
                return "Updated Successfully";
            }
            else
                return "Not Found!";
        }
        public List<Teacher> GetAllTeachers()
        {
            return teachers;
        }
    }
}
