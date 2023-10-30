using System.ComponentModel.DataAnnotations;
using System;

namespace NeyroHospital.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public DateTime SurgeryDate { get; set; }
        [Required]
        public DateTime DischargedDate { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        public string SurgeryType { get; set; }
    }
}
