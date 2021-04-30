using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ReFitPatient.Domain;

namespace ReFitPatient.DatabaseAccess
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions options):base(options)
        { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExercisePackage> ExercisePackages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(
            "Data Source = ST-I4DAB.uni.au.dk; Initial Catalog = F21ST4GRP3; User ID = F21ST4GRP3; Password=F21ST4GRP3;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
    }
}
