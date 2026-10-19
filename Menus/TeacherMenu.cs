using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Menus
{
    public class TeacherMenu
    {
        private ITeacherService teacherService;
        public TeacherMenu(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Get Teacher");
                Console.WriteLine("3. View Teachers");
                Console.WriteLine("4. Update Teacher");
                Console.WriteLine("5. Remove Teacher");
                Console.WriteLine("6. Back to Main Menu");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Teacher teacher = new Teacher();

                        Console.WriteLine("Enter Id: ");
                        teacher.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Teacher Name: ");
                        teacher.Name = Console.ReadLine();

                        Console.WriteLine("Enter Teacher Age: ");
                        teacher.Age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Teacher Email: ");
                        teacher.Email = Console.ReadLine();

                        Console.WriteLine("Enter Teacher Rank: ");
                        teacher.Rank = Console.ReadLine();

                        Console.WriteLine("Enter Teacher Rewaya: ");
                        teacher.Rewaya = int.Parse(Console.ReadLine());

                        string result = teacherService.AddTeacher(teacher);
                        Console.WriteLine(result);
                        break;

                    case "2":
                        Console.WriteLine("Enter Teacher Id to Get:");
                        int idToGet = int.Parse(Console.ReadLine());
                        teacher = teacherService.GetTeacher(idToGet);
                        if (teacher != null)
                        {
                            Console.WriteLine($"Teacher Id: {teacher.Id}");
                            Console.WriteLine($"Teacher Name: {teacher.Name}");
                            Console.WriteLine($"Teacher Age: {teacher.Age}");
                            Console.WriteLine($"Teacher Email: {teacher.Email}");
                            Console.WriteLine($"Teacher Rank: {teacher.Rank}");
                            Console.WriteLine($"Teacher Rewaya: {teacher.Rewaya}");
                        }
                        else
                        {
                            Console.WriteLine("Teacher not found.");
                        }
                        break;

                    case "3":
                        teacherService.GetAllTeachers();
                        break;

                    case "4":
                        Console.WriteLine("Enter Teacher Id to Update:");
                        int idToUpdate = int.Parse(Console.ReadLine());
                        Teacher updatedTeacher = teacherService.GetTeacher(idToUpdate);
                        if (updatedTeacher != null)
                        {
                            Console.WriteLine("Enter Updated Teacher Name:");
                            updatedTeacher.Name = Console.ReadLine();

                            Console.WriteLine("Enter Updated Teacher Age:");
                            updatedTeacher.Age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Updated Teacher Email:");
                            updatedTeacher.Email = Console.ReadLine();

                            Console.WriteLine("Enter Updated Teacher Rank:");
                            updatedTeacher.Rank = Console.ReadLine();

                            Console.WriteLine("Enter Updated Teacher Rewaya:");
                            updatedTeacher.Rewaya = int.Parse(Console.ReadLine());

                            string updateResult = teacherService.UpdateTeacher(idToUpdate, updatedTeacher);
                            Console.WriteLine(updateResult);
                        }
                        else
                        {
                            Console.WriteLine("Teacher not found.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Enter Teacher Id to Remove:");
                        int idToRemove = int.Parse(Console.ReadLine());
                        string removeResult = teacherService.RemoveTeacher(idToRemove);
                        Console.WriteLine(removeResult);
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }
            }

        }
    }
}
