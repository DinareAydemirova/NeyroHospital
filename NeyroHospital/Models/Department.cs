using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeyroHospital.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsDeactive { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
