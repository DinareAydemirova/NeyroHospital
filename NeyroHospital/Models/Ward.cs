using System.ComponentModel.DataAnnotations;

namespace NeyroHospital.Models
{
    public class Ward
    {
        public int RoomNumber { get; set; }
        [Required]
        public int Floor { get; set; }
        public bool IsDeactive { get; set; }
    }
}
