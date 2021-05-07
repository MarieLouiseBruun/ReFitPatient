using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReFitPatientCore.Domain;

namespace ReFitPatientData
{
    public class LoadDatabase
    {
        private Patient _patient;
        private readonly PatientContext _db;
        //private readonly ILogger<LoadDatabase> _logger;

        public LoadDatabase()
        {
            //_logger = new Logger<LoadDatabase>(new LoggerFactory());
            _db = new PatientContext();
        }
        public Patient LoadPatientInfo(string SSN, string PW)
        {
            var patients = _db.Patients
                .Include(e => e.Journals)
                .Include(f => f.Packages)
                .ToList();
            _patient = patients.Find(c => c.SSN == SSN);
            return _patient;
        }

        public ExercisePackage LoadPackageInfo(int ID)
        {
            return new ExercisePackage();
        }

        public Exercise LoadExerciseInfo(int ID)
        {
            return new Exercise();
        }

        //public Journal GetPreviousJournalInformation()
        //{
        //    return new Journal("a", 1, 3, "d", "e");
        //}
        public bool ValidateLogin(string SSN, string Password)
        {
            var patients = _db.Patients;
            if ((patients.Any(o => o.SSN == SSN)) && patients.Any(p => p.Password == Password))
            {
                return true;
            }
            return false;
        }
    }
}
