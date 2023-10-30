using System.ComponentModel.DataAnnotations;
using System;

namespace NeyroHospital.Models
{
    public class Appointment
    {
        public int Id { get; set; }
       
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
       
        public string Patient { get; set; }
        public bool IsDeactive { get; set; }

    }
}
