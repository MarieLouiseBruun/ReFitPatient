using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientDomain;

namespace ReFitPatientData
{
    public class PatientContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExercisePackage> ExercisePackages { get; set; }
        public DbSet<JournalCollection> JournalCollections { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(
            "Data Source=ST-I4DAB.uni.au.dk;Initial Catalog=F21ST4GRP3;User ID=F21ST4GRP3;Password=F21ST4GRP3;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
    }
}
