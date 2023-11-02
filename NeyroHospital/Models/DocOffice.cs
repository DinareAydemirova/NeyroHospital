using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NeyroHospital.Models
{
    public class DocOffice
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public Doctor Doctor { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
    }
}
