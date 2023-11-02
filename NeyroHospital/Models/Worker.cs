using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeyroHospital.Models
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string  Email { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public List<PositionWorker> PositionWorkers { get; set; }
    }
}
