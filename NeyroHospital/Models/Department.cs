using System.Collections.Generic;

namespace NeyroHospital.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeactive { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
