namespace NeyroHospital.Models
{
    public class PositionWorker
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public int WorkerId { get; set; }
        
    }
}
