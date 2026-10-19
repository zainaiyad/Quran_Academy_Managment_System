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
            Console.WriteLine("1. Students");
            Console.WriteLine("2. Teachers");
            Console.WriteLine("3. Appointments");
            Console.WriteLine("4. Registrations");
            Console.WriteLine("5. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    studentMenu.Show(); break;

                case "2":
                    teacherMenu.Show(); break;

                case "3":
                    appointmentMenu.Show(); break;

                case "4":
                    registrationMenu.Show(); break;

                case "5":
                    break;

                default: Console.WriteLine("Invalid Choice.."); break;

            }
        }
    }
}
