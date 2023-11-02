using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeyroHospital.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        public string Positions { get; set; }
        [Required]
        public List<PositionWorker> PositionWorkers { get; set; }
    }
}
