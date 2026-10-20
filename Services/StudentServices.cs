using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Services
{
    public class StudentServices : IStudentService
    {
        private List <Student > students = new List<Student>();
        public string AddStudent(Student student)
        {
            students.Add(student);
            return "Added Successfully"; 
        }
        public string RemoveStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                return "Removed Successfully";
            }
            else
                return "Not Found!";
                
        }
        public string UpdateStudent(int id, Student student)
        {
            var studentToUpdate = students.FirstOrDefault(s => s.Id == id);
            if (studentToUpdate != null)
            {
                studentToUpdate.Name = student.Name;
                studentToUpdate.Age = student.Age;
                studentToUpdate.Email = student.Email;
                studentToUpdate.Place = student.Place;
                studentToUpdate.Level = student.Level;
                return "Updated Successfully";
            }
            else
                return "Not Found!";

        }
        public Student GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return student;
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        public static List<Student> studentFilter(List<Student> students, Func<Student, bool> filter)
        {
            List<Student> filteredStudents = new List<Student>();
            foreach (var student in students)
            {
                if (filter(student))
                {
                    filteredStudents.Add(student);
                }
            }
            return filteredStudents;
        }
    }
}
