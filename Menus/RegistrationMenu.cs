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

                        registration.Id = UserHelper.ReadInt("Enter Id: ");
                        registration.StudentId = UserHelper.ReadInt("Enter Student Id: ");
                        registration.TeacherId = UserHelper.ReadInt("Enter Teacher Id: ");
                        registration.AppointmentId = UserHelper.ReadInt("Enter Appointment Id: ");
                        Console.WriteLine("Enter Paid Amount:");
                        registration.PaidAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Remaining Amount:");
                        registration.RemainingAmount = double.Parse(Console.ReadLine());
                        string result = registrationService.RegisterStudent(registration);
                        Console.WriteLine(result);
                        break;

                    case "2":
                        int registrationId = UserHelper.ReadInt("Enter Registration Id: ");
                        result = registrationService.DropStudent(registrationId);
                        Console.WriteLine(result);
                        break;

                    case "3":
                        registrationService.GetAllRegistrations();
                        break;

                    case "4":
                        registrationId = UserHelper.ReadInt("Enter Registration Id: ");
                        int teacherId = UserHelper.ReadInt("Enter New Teacher Id: ");
                        result = registrationService.ChangeTeacher(registrationId, teacherId);
                        Console.WriteLine(result);
                        break;

                    case "5":
                        registrationId = UserHelper.ReadInt("Enter Registration Id: ");
                        int newAppointmentId = UserHelper.ReadInt("Enter New Appointment Id: ");
                        result = registrationService.ChangeAppointment(registrationId, newAppointmentId);
                        Console.WriteLine(result);
                        break;

                    case "6":
                        registrationId = UserHelper.ReadInt("Enter Registration Id: ");
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
