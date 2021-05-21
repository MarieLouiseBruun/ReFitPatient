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
    /// <summary>
    /// 
    /// </summary>
    public class PatientContext : DbContext
    {
        /// <summary>
        /// propperty til patienter
        /// </summary>
        public DbSet<Patient> Patients { get; set; }

        /// <summary>
        /// propperty til dagbøger
        /// </summary>
        public DbSet<Journal> Journals { get; set; }
        /// <summary>
        /// propperty til øvelser
        /// </summary>
        public DbSet<Exercise> Exercises { get; set; }
        /// <summary>
        /// propperty til øvelsespakkeider
        /// </summary>
        public DbSet<ExercisePackage> ExercisePackages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(
            "Data Source=ST-I4DAB.uni.au.dk;Initial Catalog=F21ST4GRP3;User ID=F21ST4GRP3;Password=F21ST4GRP3;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
    }
}
