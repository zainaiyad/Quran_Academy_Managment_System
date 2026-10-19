using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Menus
{
    public class MainMenu
    {
        private StudentMenu studentMenu;
        private TeacherMenu teacherMenu;
        private AppointmentMenu appointmentMenu;
        private RegistrationMenu registrationMenu;
        public MainMenu (StudentMenu studentMenu, TeacherMenu teacherMenu, AppointmentMenu appointmentMenu, RegistrationMenu registrationMenu)
        {
            this.studentMenu = studentMenu;
            this.teacherMenu = teacherMenu;
            this.appointmentMenu = appointmentMenu;
            this.registrationMenu = registrationMenu;
        }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Quran Academy Management System");
                Console.WriteLine("1. Student Menu");
                Console.WriteLine("2. Teacher Menu");
                Console.WriteLine("3. Appointment Menu");
                Console.WriteLine("4. Registration Menu");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        studentMenu.Show();
                        break;
                    case "2":
                        teacherMenu.Show();
                        break;
                    case "3":
                        appointmentMenu.Show();
                        break;
                    case "4":
                        registrationMenu.Show();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
