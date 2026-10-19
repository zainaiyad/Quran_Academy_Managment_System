using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace QuranAcademyManagementSystem.Menus
{
    public class RegistrationMenu
    {
        private IRegistrationService registrationService;
        public RegistrationMenu(IRegistrationService registrationService)
        {
            this.registrationService = registrationService;
        }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Delete Registration");
                Console.WriteLine("3. View Registrations");
                Console.WriteLine("4. Change Teacher");
                Console.WriteLine("5. Change Appointment");
                Console.WriteLine("6. Add to Paid");
                Console.WriteLine("7. Back");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Registration registration = new Registration();

                        Console.WriteLine("Enter Id:");
                        registration.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Student Id:");
                        registration.StudentId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Id:");
                        registration.TeacherId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Appointment Id:");
                        registration.AppointmentId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Paid Amount:");
                        registration.PaidAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Remaining Amount:");
                        registration.RemainingAmount = double.Parse(Console.ReadLine());
                        string result = registrationService.RegisterStudent(registration);
                        Console.WriteLine(result);
                        break;

                    case "2":
                        Console.WriteLine("Enter Registration Id to Delete Registration:");
                        int registrationId = int.Parse(Console.ReadLine());
                        result = registrationService.DropStudent(registrationId);
                        Console.WriteLine(result);
                        break;

                    case "3":
                        registrationService.GetAllRegistrations();
                        break;

                    case "4":
                        Console.WriteLine("Enter Registration Id to Change Teacher:");
                        registrationId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter New Teacher Id:");
                        int teacherId = int.Parse(Console.ReadLine());
                        result = registrationService.ChangeTeacher(registrationId, teacherId);
                        Console.WriteLine(result);
                        break;

                    case "5":
                        Console.WriteLine("Enter Registration Id to Change Appointment:");
                        registrationId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter New Appointment Id:");
                        int newAppointmentId = int.Parse(Console.ReadLine());
                        result = registrationService.ChangeAppointment(registrationId, newAppointmentId);
                        Console.WriteLine(result);
                        break;

                    case "6":
                        Console.WriteLine("Enter Registration Id to Add to Paid:");
                        registrationId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Amount to Add:");
                        double amount = double.Parse(Console.ReadLine());
                        result = registrationService.AddToPaid(registrationId, amount);
                        Console.WriteLine(result);
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }
            }
        }
    }
}
