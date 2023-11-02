﻿using System.ComponentModel.DataAnnotations;
using System;

namespace NeyroHospital.Models
{
    public class Inpatient
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public bool IsFemale { get; set; }
        [Required]
        public DateTime SurgeryDate { get; set; }
        [Required]
        public DateTime DischargedDate { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        public string SurgeryType { get; set; }
        [Required]
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public Ward Ward { get; set; }
        public int WardId { get; set; }
    }
}
