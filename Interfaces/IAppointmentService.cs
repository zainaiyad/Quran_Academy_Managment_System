using QuranAcademyManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Interfaces
{
    public interface IAppointmentService
    {
        string AddAppointment (Appointment appointment);
        string RemoveAppointment (int id);
        Appointment GetAppointment (int id);
        string UpdateAppointment (int id, Appointment appointment);
        List <Appointment> GetAllAppointments ();
    }
}
