using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeyroHospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public int Age { get; set; }
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        
        public bool IsDeactive { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public List<Appointment> Appointments { get; set; }
        public DocOffice DocOffice { get; set; }
    }
}
