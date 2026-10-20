using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.Services;
using QuranAcademyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Menus
{
    public class StudentMenu
    {
        private IStudentService studentService;

        public StudentMenu(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Get Student");
                Console.WriteLine("5. View Students");
                Console.WriteLine("6. View Students Under a Certain Age");
                Console.WriteLine("7. Back");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Student student = new Student();

                        Console.WriteLine("Enter Student Id:");
                        student.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Student Name:");
                        student.Name = Console.ReadLine();

                        student.Age = UserHelper.ReadInt("Enter Student Age");

                        Console.WriteLine("Enter Student Email:");
                        student.Email = Console.ReadLine();

                        Console.WriteLine("Enter Student Place:");
                        student.Place = Console.ReadLine();

                        student.Level = UserHelper.ReadInt("Enter Student Level:");

                        string result = studentService.AddStudent(student);
                        Console.WriteLine(result);
                        break;

                    case "2":
                        int idToRemove = UserHelper.ReadInt("Enter Student Id to Remove:");
                        string removeResult = studentService.RemoveStudent(idToRemove);
                        Console.WriteLine(removeResult);
                        break;

                    case "3":
                        
                        int idToUpdate = UserHelper.ReadInt("Enter Student Id to Update");
                        Student updatedStudent = studentService.GetStudent(idToUpdate);
                        if (updatedStudent != null)
                        {
                            Console.WriteLine("Enter Updated Student Name:");
                            updatedStudent.Name = Console.ReadLine();

                            updatedStudent.Age = UserHelper.ReadInt("Enter Updated Student Age");

                            Console.WriteLine("Enter Updated Student Email:");
                            updatedStudent.Email = Console.ReadLine();

                            Console.WriteLine("Enter Updated Student Place:");
                            updatedStudent.Place = Console.ReadLine();

                            updatedStudent.Level = UserHelper.ReadInt("Enter Updated Student Level");

                            string updateResult = studentService.UpdateStudent(idToUpdate, updatedStudent);
                            Console.WriteLine(updateResult);
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case "4":
                        int idToGet = UserHelper .ReadInt("Enter Student Id to Get:");
                        student = studentService.GetStudent(idToGet);
                        if (student != null)
                        {
                            Console.WriteLine($"Student Id: {student.Id}");
                            Console.WriteLine($"Student Name: {student.Name}");
                            Console.WriteLine($"Student Age: {student.Age}");
                            Console.WriteLine($"Student Email: {student.Email}");
                            Console.WriteLine($"Student Place: {student.Place}");
                            Console.WriteLine($"Student Level: {student.Level}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case "5":
                        studentService.GetAllStudents(); break;

                    case "6":
                        int ageLimit = UserHelper.ReadInt("Enter Age Limit:");
                        var filteredStudents = StudentServices.studentFilter(studentService.GetAllStudents(), s => s.Age < ageLimit);
                        foreach (var filteredStudent in filteredStudents)
                        {
                            Console.WriteLine($"Student Id: {filteredStudent.Id}");
                            Console.WriteLine($"Student Name: {filteredStudent.Name}");
                            Console.WriteLine($"Student Age: {filteredStudent.Age}");
                            Console.WriteLine($"Student Email: {filteredStudent.Email}");
                            Console.WriteLine($"Student Place: {filteredStudent.Place}");
                            Console.WriteLine($"Student Level: {filteredStudent.Level}");
                        }
                        break;

                    case "7":
                        return;

                    default: Console.WriteLine("Invalid choice. Please try again."); break;

                }
            }
        }
    }
}
