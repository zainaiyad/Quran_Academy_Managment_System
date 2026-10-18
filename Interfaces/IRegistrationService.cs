using QuranAcademyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Interfaces
{
    public interface IRegistrationService
    {
        string RegisterStudent(Registration registration);
        string DropStudent(int registrationId);
        string ChangeTeacher(int registrationId, int teacherId);
        string ChangeAppointment (int registrationId, int appointmentId);
        string AddToPaid(int registrationId, double Amount);
        string GetRegistration(int id);
        List <Registration > GetAllRegistrations();
    }
}
