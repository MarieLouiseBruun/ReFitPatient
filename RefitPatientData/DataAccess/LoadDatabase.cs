using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReFitPatientDomain;
using ReFitPatientData;

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
                .Include(f => f.ExercisePackages)
                .ThenInclude(g => g.Exercises)
                .FirstOrDefault(c => c.SSN == SSN);

            _patient = patients;
            return _patient;
        }

        
        public bool ValidateLogin(string SSN, string Password)
        {
            var patients = _db.Patients;
            if (patients.Any(o => o.SSN == SSN && o.Password == Password))
            {
                return true;
            }
            return false;
        }
    }
}
