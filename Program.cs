using QuranAcademyManagementSystem.Menus;
using QuranAcademyManagementSystem.Models;
using QuranAcademyManagementSystem.Services;

namespace QuranAcademyManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Registration> registrations = new List<Registration>();
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Appointment> appointments = new List<Appointment>();

            RegistrationServices registrationServices = new RegistrationServices();
            StudentServices studentServices = new StudentServices();
            TeacherServices teacherServices = new TeacherServices();
            AppointmentServices appointmentServices = new AppointmentServices();

            RegistrationMenu registrationMenu = new RegistrationMenu(registrationServices);
            StudentMenu studentMenu = new StudentMenu(studentServices);
            TeacherMenu teacherMenu = new TeacherMenu(teacherServices);
            AppointmentMenu appointmentMenu = new AppointmentMenu(appointmentServices);

            MainMenu mainMenu = new MainMenu(studentMenu, teacherMenu, appointmentMenu, registrationMenu);

            mainMenu.Show();

        }
    }
}
