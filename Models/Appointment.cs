using System;
using System.Collections.Generic;
using System.Text;

namespace QuranAcademyManagmentSystem.Models
{
    public  class Appointment
    {
        public int Id { get; set; }   
        public string Day { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
    }
}
