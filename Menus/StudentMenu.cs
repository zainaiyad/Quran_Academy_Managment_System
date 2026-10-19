using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.Services;
using QuranAcademyManagementSystem.models;
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
                Console.WriteLine("6. Back");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Student student = new Student();

                        Console.WriteLine("Enter Student Id:");
                        student.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Student Name:");
                        student.Name = Console.ReadLine();

                        Console.WriteLine("Enter Student Age:");
                        student.Age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Student Email:");
                        student.Email = Console.ReadLine();

                        Console.WriteLine("Enter Student Place:");
                        student.Place = Console.ReadLine();

                        Console.WriteLine("Enter Student Level:");
                        student.Level = int.Parse(Console.ReadLine());

                        string result = studentService.AddStudent(student);
                        Console.WriteLine(result);
                        break;

                    case "2":
                        Console.WriteLine("Enter Student Id to Remove:");
                        int idToRemove = int.Parse(Console.ReadLine());
                        string removeResult = studentService.RemoveStudent(idToRemove);
                        Console.WriteLine(removeResult);
                        break;

                    case "3":
                        Console.WriteLine("Enter Student Id to Update:");
                        int idToUpdate = int.Parse(Console.ReadLine());
                        Student updatedStudent = studentService.GetStudent(idToUpdate);
                        if (updatedStudent != null)
                        {
                            Console.WriteLine("Enter Updated Student Name:");
                            updatedStudent.Name = Console.ReadLine();

                            Console.WriteLine("Enter Updated Student Age:");
                            updatedStudent.Age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Updated Student Email:");
                            updatedStudent.Email = Console.ReadLine();

                            Console.WriteLine("Enter Updated Student Place:");
                            updatedStudent.Place = Console.ReadLine();

                            Console.WriteLine("Enter Updated Student Level:");
                            updatedStudent.Level = int.Parse(Console.ReadLine());

                            string updateResult = studentService.UpdateStudent(idToUpdate, updatedStudent);
                            Console.WriteLine(updateResult);
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter Student Id to Get:");
                        int idToGet = int.Parse(Console.ReadLine());
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
                        return;

                    default: Console.WriteLine("Invalid choice. Please try again."); break;

                }
            }
        }
    }
}
