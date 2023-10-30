using System.Collections.Generic;

namespace NeyroHospital.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Positions { get; set; }
        public List<PositionWorker> PositionWorkers { get; set; }
    }
}
