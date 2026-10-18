using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagementSystem.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherID { get; set; }
        public int AppointmentId { get; set; }
        public double PaidAmount { get; set; }
        public double RemainingAmount { get; set; }
    }
}
