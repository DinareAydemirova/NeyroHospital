using Microsoft.EntityFrameworkCore;
using NeyroHospital.Models;

namespace NeyroHospital.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<PositionWorker> PositionWorkers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DocOffice> DocOffices { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Inpatient> Inpatients { get; set; }
        public DbSet<Outpatient> Outpatients { get; set; }
        public DbSet<Ward> Wards { get; set; }






    }
}
