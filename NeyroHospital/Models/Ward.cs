using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeyroHospital.Models
{
    public class Ward
    {
        public int Id { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public int Floor { get; set; }
        public bool IsDeactive { get; set; }
        public List<Inpatient> Inpatient { get; set; }
    }
}
