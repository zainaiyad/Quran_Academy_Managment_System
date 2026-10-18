using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Services
{
    public class AppointmentServices :IAppointmentService
    {
        private List <Appointment> appointments = new List <Appointment> ();
        public string AddAppointment(Appointment appointment)
        {
            appointments.Add (appointment);

            return "Added Successfully";
        }
        public string RemoveAppointment(int id)
        {
            var appointment = appointments.FirstOrDefault (appointment => appointment.Id == id);
            if (appointment != null)
            {
                appointments.Remove(appointment);
                return "Removed Successfully";
            }
            else
                return "Not Found!";
                
        }
        public Appointment GetAppointment(int id)
        {
            var appointment = appointments.FirstOrDefault(appointment => appointment.Id == id);
            return appointment;
        }
        public string UpdateAppointment(int id, Appointment appointment)
        {
            var appointmentToUpdate = appointments.FirstOrDefault(appointment => appointment.Id == id);
            if (appointmentToUpdate != null)
            {
                appointmentToUpdate = appointment;
                return "Updated Successfully";
            }
        
            else
                return "Not Found!";
        }
        public List<Appointment> GetAllAppointments()
        {
            return appointments;
        }
    }
}
