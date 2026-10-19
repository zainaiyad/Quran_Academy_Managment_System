using QuranAcademyManagementSystem.Interfaces;
using QuranAcademyManagementSystem.Models;
using QuranAcademyManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Services
{
    public class RegistrationServices : IRegistrationService
    {
        private List <Registration> registrations = new List <Registration> ();
        public string RegisterStudent(Registration registration)
        {
            registrations.Add (registration);

            return "Successfully Registration";
        }
        public string DropStudent(int registrationId)
        {
            var registration = registrations.FirstOrDefault(registration =>  registration.Id == registrationId);
            if (registration != null)
            {
                registrations.Remove(registration);
                return "Drop Student Successfully";
            }
            else return "Nor Found!";
            
        }
        public string ChangeTeacher(int registrationId, int teacherId)
        {
            var registration = registrations.FirstOrDefault(registration => registration.Id == registrationId);
            if (registration != null)
            {
                registration.TeacherID = teacherId;
                return "Changed!";
            }
            else
                return "Not Found!";
        }
        public string ChangeAppointment(int registrationId, int appointmentId)
        {
            var registration = registrations.FirstOrDefault(registration => registration.Id == registrationId);
            if (registration != null)
            {
                registration.AppointmentId = appointmentId;
                return "Changed!";
            }
            else
                return "Not Found!";

        }
        public string AddToPaid(int registrationId, double Amount)
        {
            var registration = registrations.FirstOrDefault(registration => registration.Id == registrationId);
            if (registration != null)
            {
                registration.PaidAmount += Amount;
                registration .RemainingAmount -= Amount;
                return "Add to Paid";
            }
            else
                return "Not Found!";
        }
        public Registration GetRegistration(int id)
        {
            var registration = registrations .FirstOrDefault(registration => registration.Id == id);
            return registration;
        }
        public List<Registration> GetAllRegistrations()
        {
            return registrations;
        }
    }
}
