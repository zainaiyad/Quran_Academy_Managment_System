using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Menus
{
    public class AppointmentMenu
    {
        private IAppointmentService appointmentService;
        public AppointmentMenu(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("1. Add Appointment");
                Console.WriteLine("2. Get Appointment");
                Console.WriteLine("3. View Appointments");
                Console.WriteLine("4. Update Appointment");
                Console.WriteLine("5. Remove Appointment");
                Console.WriteLine("6. Back");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Appointment appointment = new Appointment();

                        Console.WriteLine("Enter Id:");
                        appointment.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Day:");
                        appointment.Day = Console.ReadLine();

                        Console.WriteLine("Enter Start Hour:");
                        appointment.StartHour = Console.ReadLine();

                        Console.WriteLine("Enter End Hour:");
                        appointment.EndHour = Console.ReadLine();

                        string result = appointmentService.AddAppointment(appointment);
                        Console.WriteLine(result);
                        break;

                    case "2":
                        Console.WriteLine("Enter Appointment Id:");
                        int appointmentId = int.Parse(Console.ReadLine());
                        Appointment appointmentDetails = appointmentService.GetAppointment(appointmentId);
                        if (appointmentDetails != null)
                        {
                            Console.WriteLine($"Id: {appointmentDetails.Id}");
                            Console.WriteLine($"Day: {appointmentDetails.Day}");
                            Console.WriteLine($"Start Hour: {appointmentDetails.StartHour}");
                            Console.WriteLine($"End Hour: {appointmentDetails.EndHour}");
                        }
                        else
                        {
                            Console.WriteLine("Appointment not found.");
                        }
                        break;

                    case "3":
                        appointmentService.GetAllAppointments();
                        break;

                    case "4":
                        Console.WriteLine("Enter Appointment Id to Update:");
                        int updateAppointmentId = int.Parse(Console.ReadLine());
                        Appointment updateAppointment = appointmentService.GetAppointment(updateAppointmentId);
                        if (updateAppointment != null)
                        {
                            Console.WriteLine("Enter New Day:");
                            updateAppointment.Day = Console.ReadLine();
                            Console.WriteLine("Enter New Start Hour:");
                            updateAppointment.StartHour = Console.ReadLine();
                            Console.WriteLine("Enter New End Hour:");
                            updateAppointment.EndHour = Console.ReadLine();
                            string updateResult = appointmentService.UpdateAppointment(updateAppointmentId, updateAppointment);
                            Console.WriteLine(updateResult);
                        }
                        else
                        {
                            Console.WriteLine("Appointment not found.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Enter Appointment Id to Remove:");
                        int removeAppointmentId = int.Parse(Console.ReadLine());
                        string removeResult = appointmentService.RemoveAppointment(removeAppointmentId);
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

