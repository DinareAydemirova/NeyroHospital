using System;
using System.Collections.Generic;

namespace NeyroHospital.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string  Email { get; set; }
        public DateTime StartDate { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public List<PositionWorker> PositionWorkers { get; set; }
    }
}
