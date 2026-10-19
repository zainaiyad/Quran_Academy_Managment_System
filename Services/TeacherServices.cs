using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.models;
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
                teacherToUpdate.Name = teacher.Name;
                teacherToUpdate.Age = teacher.Age;
                teacherToUpdate.Rank = teacher.Rank;
                teacherToUpdate.Email = teacher.Email;
                teacherToUpdate .Rewaya = teacher.Rewaya;
               
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
