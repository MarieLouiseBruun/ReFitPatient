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
    /// <summary>
    /// henter oplysninger fra databasen
    /// </summary>
    public class LoadDatabase :ILoadDatabase
    {
        private Patient _patient;
        private readonly PatientContext _db;
        //private readonly ILogger<LoadDatabase> _logger;

        /// <summary>
        /// constructor til loaddatbase
        /// </summary>
        public LoadDatabase()
        {
            //_logger = new Logger<LoadDatabase>(new LoggerFactory());
            _db = new PatientContext();
        }

        /// <summary>
        /// opretter en ny patient hvis cpr og password passer til en patient i databasen 
        /// </summary>
        /// <param name="SSN">cprnummer</param>
        /// <param name="PW">password</param>
        /// <returns>Patienten med informationer fra databasen</returns>
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

        /// <summary>
        /// validere login. tjekker altså om der findes en patient i databasen med cprnummeret og passwordet
        /// </summary>
        /// <param name="SSN">cprnummer</param>
        /// <param name="Password"></param>
        /// <returns>true, hvis patienten findes, false hvis han ikke gør</returns>
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
